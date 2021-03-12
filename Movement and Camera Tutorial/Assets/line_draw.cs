using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_draw : MonoBehaviour
{
    LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            line.positionCount++;
            line.startWidth = 0.1f;
            line.endWidth = 0.1f;
           
            line.SetPosition(line.positionCount - 1, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)));
        }

    }
}
