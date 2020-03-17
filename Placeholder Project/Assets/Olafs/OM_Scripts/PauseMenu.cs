using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    // KEEP TRACK OF THE GAME IF THE GAME IS PAUSED

        // STATIC VARIABLE TO CHECK IF THE GAME IS PAUSED
        // SET THE GAME VALUE FALSE TO ACTIVATE IT WITH THE CODE
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        // WHEN PRESSING KEY ESCAPE THE GAME WILL BE PAUSED
       if (Input.GetKeyDown(KeyCode.Escape))
        { 
            // GETTING TWO ACTIONS WHEN THE BUTTON IS PRESSED
            if (GameIsPaused)
            {
                // SHOW GAME SCREEN
                Resume();
            }
            else
            {
                // SET THE GAME TO PAUSE SCREEN
                Pause();
            }
        }
    }
    // WHEN THE GAME IS ACTIVATED THE TIME TURNS TO NORMAL RATE
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    // WHEN THE ESCAPE BUTTON IS PRESSED THE TIME WILL STOP WHICH WILL BRING OUT THE RESUME MENU
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // LOADS THE MAIN MENU
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // BUTTON QUIT EXITS THE GAME
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
