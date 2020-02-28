﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * MovementSpeed;
        }
        else if (Input.GetKey ("s"))
        {
           transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * MovementSpeed;
        }

        if (Input.GetKey("a") && !Input.GetKey ("d"))
        {
           transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * MovementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * MovementSpeed;
        }
    }
}
