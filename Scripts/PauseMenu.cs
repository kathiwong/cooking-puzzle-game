using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; //Resume the game
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseMenuUI.transform.SetAsLastSibling(); //Ensure the pause menu is on top
        Time.timeScale = 0f; //Freeze the game
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; //Ensure time scale is reset
        SceneManager.LoadScene("MainMenu");
    }

}
