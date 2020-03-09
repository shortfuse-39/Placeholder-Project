using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Add one to the collectable on the level Manager
        Level_Manager.in_collectables++;

    }

    //---------------------------------------------------------------------------------------------------------------
    // Detect if something enters the trigger
    void OnTriggerEnter(Collider _cl_detected)
    {
        if (_cl_detected.tag == "Player")
        {// Update stats in level Manager
            Level_Manager.in_collectables--;


            Destroy(gameObject);
        }
    }
}
