using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Inertia : MonoBehaviour
{
    // https://forum.unity.com/threads/best-player-movement-script-in-c-3d.435803/
    public float MovementSpeed;
    private Rigidbody rigidBody;
    public float MaximumSpeed = 10;
       
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rigidBody.velocity += transform.TransformDirection(Vector3.forward) * Time.deltaTime * MovementSpeed;
            Debug.Log("Forward!");
        }
        else if (Input.GetKey("s"))
        {
            rigidBody.velocity -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * MovementSpeed;
            Debug.Log("Back!");
        }

        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            rigidBody.velocity += transform.TransformDirection(Vector3.left) * Time.deltaTime * MovementSpeed;
            Debug.Log("Right!");
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            rigidBody.velocity -= transform.TransformDirection(Vector3.left) * Time.deltaTime * MovementSpeed;
            Debug.Log("Left!");
        }

        {
            if (rigidBody.velocity.magnitude > MaximumSpeed)
            { 
                rigidBody.velocity = rigidBody.velocity.normalized * MaximumSpeed;
            }
        }
    }
    
    
}