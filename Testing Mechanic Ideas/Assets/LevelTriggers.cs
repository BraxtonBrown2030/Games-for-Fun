using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class LevelTriggers : MonoBehaviour
{
    public Canvas levelComplete;
    public int secneToLoad;
    public SOLevelTrigger soLevelTrigger;


    void Start()
    {

        soLevelTrigger.plateTrigger = false;
        soLevelTrigger.itemGrabed = false;
        

    }

    
    void Update()
    {
    

        if(soLevelTrigger.plateTrigger == true && soLevelTrigger.numberReached == true)
        {

            soLevelTrigger.nextLevel = true;

        }



    }

    public void LoadNextScene()
    {

        if(soLevelTrigger.nextLevel == true)
        {

            SceneManager.LoadScene(secneToLoad);

        }


    }

    public void OnTriggerEnter(Collider other)
    {

        if(this.tag == "Plate" && other.tag == "Player")
        {
            soLevelTrigger.plateTrigger = true;
        }

        if(this.tag == "item" && other.tag == "Player")
        {
            soLevelTrigger.itemGrabed = true;
        }


    }


}
