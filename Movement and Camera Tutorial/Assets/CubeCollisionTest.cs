using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionTest : MonoBehaviour
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
            physics_move.angularVelocity = new Vector3(0, 180, 0);
    }

    internal void youve_been_hit()
    {
        isSpinning = true;
        ourRenderer.material.color = Color.yellow;
    }
}
