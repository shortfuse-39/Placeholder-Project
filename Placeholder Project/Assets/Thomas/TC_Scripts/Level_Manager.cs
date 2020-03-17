//---------------------------------------------------------------------------------------
// Simple 2D Level Manager
// David Dorrington, UEL Games, 2017 
//---------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    //---------------------------------------------------------------------------------------
    // Game State Variables
    public static int in_collectables;

    bool gameHasEnded = false;
    private Text text_stats;


    


    //---------------------------------------------------------------------------------------
    // Use this for initialization
    void Start ()
    {
        // Find areference to the text panel
        text_stats = GameObject.Find("Stats_Text").GetComponent<Text>();
    }//-----

    public void CompleteLevel()
    {
        Debug.Log("LEVEL COMPLETED");
    }

    public void EndGame()
    { 
        if (gameHasEnded == false)

        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

        }
    }
    //---------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update ()
    {
        UpdateGUI();
	}//-----


    //---------------------------------------------------------------------------------------
    void UpdateGUI()
    {
        //update the game stats panel text
        text_stats.text =  "STARLIGHT REMAINING: " + in_collectables.ToString();
    }//-----

}//==========
