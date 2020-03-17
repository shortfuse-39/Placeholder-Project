using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGoal : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "EndPlatform")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}