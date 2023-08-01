using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using TMPro.EditorUtilities;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{

    public bool mainSettings = false;
    public bool gameSettings = false;

    public Canvas settingsCanvas;
    public Canvas gamePaused;
    public Canvas deathmenu;
    public Canvas settingsDeath;
    public Canvas settingsCanvasMain;

    public Slider VaulumeSettings;

    public float musicSorce;
    public bool lastMenuOpen;

    public int _Gamescene = 1;
    public int _Settings = 2;
    public int _MainMenu = 0;

    public void Start()
    {

        settingsCanvas = GameObject.FindGameObjectWithTag("Settings").GetComponent<Canvas>();
        gamePaused = GameObject.FindGameObjectWithTag("Pause Menu").GetComponent<Canvas>();
        deathmenu = GameObject.FindGameObjectWithTag("Death Menu").GetComponent<Canvas>();
        settingsCanvasMain = GameObject.FindGameObjectWithTag("Settings_Main").GetComponent<Canvas>();

    }

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

        lastMenuOpen = true;
        settingsCanvas.enabled = true;
        gamePaused.enabled = false;

        Debug.Log("Canavas S Enables");

    }

    public void SettignsMain()
    {

        lastMenuOpen = false;
       settingsCanvasMain.enabled = true;
       deathmenu.enabled = false;

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

    public void CloseSettigns()
    {

        settingsCanvas.enabled =false;
        gamePaused.enabled = true;

    }
    
    public void CloaseSetteingDeath()
    {


        settingsCanvasMain.enabled = false;
        deathmenu.enabled = true;

    }

}
