using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionTest : base_character,IDamagable
{
    bool isSpinning = false;
    Rigidbody physics_move;
    Renderer ourRenderer;

    // Start is called before the first frame update
    void Start()
    {
        physics_move = GetComponent<Rigidbody>();
        ourRenderer = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpinning)
            turn_left();
    }

    internal void youve_been_hit()
    {
        isSpinning = true;
        ourRenderer.material.color = Color.yellow;
    }

    internal override bool should_move_forward()
    {
        return false;
    }

    internal override bool should_move_backward()
    {
        return false;
    }

    internal override bool should_strafe_left()
    {
        return false;
    }

    internal override bool should_strafe_right()
    {
        return true;
    }
}
