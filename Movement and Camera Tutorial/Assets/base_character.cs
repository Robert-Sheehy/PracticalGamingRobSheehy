using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class base_character : MonoBehaviour,IDamagable
{
    int health = 100;
    private float turning_speed = 180;
    internal float current_speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    internal void Update()

    {        // Implement motion
        if (should_move_forward()) move_forward();
        if (should_move_backward()) move_backward();
        if (should_strafe_left()) strafe_left();
        if (should_strafe_right()) strafe_right();
        print("Hello");
        
    }


    internal abstract bool should_move_forward();

    internal abstract bool should_move_backward();
    internal abstract bool should_strafe_left();
    internal abstract bool should_strafe_right();


    internal void turn_right()
    {
        transform.Rotate(Vector3.up, turning_speed * Time.deltaTime);
    }

    internal void turn_left()
    {
        transform.Rotate(Vector3.up, -turning_speed * Time.deltaTime);
    }


    internal void strafe_right()
    {
        transform.position += current_speed * transform.right * Time.deltaTime;
    }


    internal void strafe_left()
    {
        transform.position -= current_speed * transform.right * Time.deltaTime;
    }


    /// <summary>
    /// Move the gameobject forward relative to its own orientation
    /// </summary>
    internal void move_forward()
    {

        transform.position += current_speed * transform.forward * Time.deltaTime;
    }
    internal void move_backward()
    {

        transform.position -= current_speed * transform.forward * Time.deltaTime;
    }

    public void apply_damage(int damage_amount)
    {
        health -= damage_amount;
    }

    public bool has_died()
    {
        return health <= 0;
    }
}
