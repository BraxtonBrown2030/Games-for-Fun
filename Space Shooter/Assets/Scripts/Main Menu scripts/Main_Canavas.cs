using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using Newtonsoft.Json.Converters;

public class Main_Canavas : MonoBehaviour
{

    public bool mainSetting;
    public bool mainPage;

    public Canvas mmSettings;
    public Canvas mmStart;

    void Start()
    {
        
        mmStart = GameObject.FindGameObjectWithTag("MM Start").GetComponent<Canvas>();
        mmSettings = GameObject.FindGameObjectWithTag("MM Settings").GetComponent<Canvas>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Tab))
        {

            SettingsStartup();

        }
        


    }

    public void SettingsStartup()
    {

        mmStart.enabled = false;
        mmSettings.enabled = true;

    }

    public void MainmenuSart()
    {

        mmSettings.enabled = false;
        mmStart.enabled = true;
        PlayerPrefs.Save();

    }

    public void QuitGame()
    {

        Application.Quit();

    }

    public void StartGame(int amount)
    {

        SceneManager.LoadScene(amount);

    }
}
