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
    public Canvas levelFailed;
    public int secneToLoad;
    public SOLevelTrigger soLevelTrigger;
    [SerializeField] private GameObject plateTrigger;


    void Start()
    {

        soLevelTrigger.plateTrigger = false;
        soLevelTrigger.itemGrabed = false;

        levelFailed.enabled = false;
        levelComplete.enabled = false;

        plateTrigger = GameObject.FindGameObjectWithTag("Plate");

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
            plateTrigger.transform.position = new Vector3(0,-3,0);    
            
        }

        if(this.tag == "item" && other.tag == "Player")
        {
            soLevelTrigger.itemGrabed = true;
        }
        
        if(this.tag == "Wall" && other.tag == "Player")
        {

            Time.timeScale = 0;
            levelFailed.enabled = true;

        }

    }


}
