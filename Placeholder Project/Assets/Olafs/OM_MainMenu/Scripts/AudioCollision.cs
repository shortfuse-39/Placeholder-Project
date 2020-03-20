using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollision : MonoBehaviour
{
   
    public AudioSource source;
    public AudioClip collisionSound;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    { if (collision.gameObject.tag == "BottomWater")
        {
            source.PlayOneShot(collisionSound);
        }
        
    }

}


