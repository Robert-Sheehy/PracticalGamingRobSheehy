using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    // Start is called before the first frame update


    Animator char_animation;
    void Start()
    {
        char_animation = GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) char_animation.SetBool("IsWalking", true);
        else
            char_animation.SetBool("IsWalking", false);

        if (Input.GetKey(KeyCode.LeftShift))
            char_animation.SetFloat("speed", 3.0f);
        else
            char_animation.SetFloat("speed", 1.0f);

    }
}
