using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float camera_distance = 10;
    float camera_height = 3;
    float focus_distance = 100;
    private Vector3 desired_position;
    private Quaternion desired_orientation;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, desired_position, 0.05f);
        transform.rotation = Quaternion.Slerp(transform.rotation, desired_orientation, 0.05f);
    }

    internal void my_Position_is(Transform character, float elevation_angle)
    {
        Vector3 focus = character.position + focus_distance * character.forward;//
        transform.position = character.position - character.forward * camera_distance + Vector3.up*camera_height;
        transform.LookAt(focus);

    //    desired_position = character.position - character.forward * camera_distance + Vector3.up * camera_height;
    //    Vector3 from_camera_to_focus = focus - transform.position;
    //    desired_orientation = Quaternion.AngleAxis(elevation_angle, character.right) * Quaternion.LookRotation(from_camera_to_focus.normalized, Vector3.up) ;
    //
    }
}
