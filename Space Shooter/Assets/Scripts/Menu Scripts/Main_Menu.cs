using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public int _Gamescene = 1;
    public int _Settings = 2;
    public int _MainMenu = 0;

    public void StartGame()
    {

        SceneManager.LoadScene(_Gamescene);
        Debug.Log("Load working");

    }

    public void Quit()
    {

        Application.Quit();
        Debug.Log("Game Quit");

    }

    public void Settings()
    {

        SceneManager.LoadScene(_Settings);
    
    }

    public void MainMenu()
    {

        SceneManager.LoadScene(_MainMenu);

    }


}
