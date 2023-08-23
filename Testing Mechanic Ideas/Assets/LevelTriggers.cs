using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class LevelTriggers : MonoBehaviour
{
    public Canvas levelComplete;
    public int secneToLoad;
    public SOLevelTrigger soLevelTrigger;


    void Start()
    {
        
    }

    
    void Update()
    {
    

    }

    public void LoadNextScene()
    {

        if(soLevelTrigger.nextLevel == true)
        {

            SceneManager.LoadScene(secneToLoad);

        }


    }

}
