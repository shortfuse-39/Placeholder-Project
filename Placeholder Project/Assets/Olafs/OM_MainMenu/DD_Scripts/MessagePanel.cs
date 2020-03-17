using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePanel : MonoBehaviour
{
    private string text;
    public bool display = false;

    private void OnTriggerEnter(Collider iCollide)
    {
        if (iCollide.transform.name == "Player")
        {
            display = true;
        }
        
    }

    private void OnTriggerExit(Collider uCollide)
    {
        if(uCollide.transform.name == "Player")
        {
            display = false;

        }
        
    }

}
