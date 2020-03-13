using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // SETTING A SCENE SWITCH TO THE MAIN MENU 

    public void MainMenuScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   

    // OPTION SCENE
    public void OptionMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    // BUTTON QUIT
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
 
}

