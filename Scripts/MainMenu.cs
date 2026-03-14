using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_Dropdown maxTileDropdown;
    private readonly int[] maxTileOptions = { 64, 128, 256, 512, 1024, 2048 };

   //when play
    public void StartGameMode(string sceneName)
    {

        Debug.Log("Start Game Mode: " + sceneName);
        SceneManager.LoadScene(sceneName);

    }

    //when press quit button
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }


}
