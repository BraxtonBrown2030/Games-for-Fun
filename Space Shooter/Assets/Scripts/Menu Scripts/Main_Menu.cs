using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro.EditorUtilities;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public bool mainSettings = false;
    public bool gameSettings = false;

    public int _Gamescene = 1;
    public int _Settings = 2;
    public int _MainMenu = 0;

    public void StartGame(int amount)
    {

        SceneManager.LoadScene(amount);
        Debug.Log("Load working");

    }

    public void Quit()
    {

        Application.Quit();
        Debug.Log("Game Quit");

    }

    public void SettingsGame()
    {

        SceneManager.LoadScene(_Settings);
        gameSettings = true;

    }

    public void SettignsMain()
    {

        SceneManager.LoadScene(_Settings);
        mainSettings = true;

    }

    public void MainMenu()
    {

        SceneManager.LoadScene(_MainMenu);

    }

    public void Return()
    {

        if(gameSettings == true)
        {

            SceneManager.LoadScene(_Gamescene);
            gameSettings = false;

        }  
        if(mainSettings == true)
        {

            SceneManager.LoadScene(_MainMenu);
            mainSettings = false;

        }      

    }

}
