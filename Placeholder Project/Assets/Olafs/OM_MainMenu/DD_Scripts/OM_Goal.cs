using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OM_Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider _cl_detected)
    {
        if (_cl_detected.tag == "Player")
        {// Update stats in level Manager
            SceneManager.LoadScene("EndScreen");



            Destroy(gameObject);
        }
    }
    
}
