﻿//---------------------------------------------------------------------------------------
// Simple 2D Level Manager
// David Dorrington, UEL Games, 2017 
//---------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Manager : MonoBehaviour
{
    //---------------------------------------------------------------------------------------
    // Game State Variables
    public static int in_collectables;
    
    private Text text_stats;

    //---------------------------------------------------------------------------------------
    // Use this for initialization
    void Start ()
    {
        // Find areference to the text panel
        text_stats = GameObject.Find("Stats_Text").GetComponent<Text>();
    }//-----


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
        text_stats.text =  "Starlight remaining: " + in_collectables.ToString();
    }//-----

}//==========
