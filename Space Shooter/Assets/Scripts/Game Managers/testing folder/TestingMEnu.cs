using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class TestingMEnu : ScriptableObject
{

    public bool mainSettings = false;
    public bool gameSettings = false;

    public int _Settings = 2;
    public int _Gamescene = 1;
    public int _MainMenu = 0;

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
