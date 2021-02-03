using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class focus_control : MonoBehaviour
{
    private float distance_to_crosshair =100;
    Transform owner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = owner.position + owner.forward * distance_to_crosshair;


    }

    internal void starting_setup(Transform character)
    {
        transform.position = character.position + character.forward * distance_to_crosshair;
        owner = character;
    }
}
