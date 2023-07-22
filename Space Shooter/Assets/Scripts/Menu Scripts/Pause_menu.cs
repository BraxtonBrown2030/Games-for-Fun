using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pause_menu : MonoBehaviour
{
    private Player_Controller _Player;
    public bool paused = false;
    public float timenumber = 0;


    void Start()
    {

        
        _Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        
        if(_Player != null)
        {
            
            GetComponent<Canvas>().enabled = false;
           

        }

    }


    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            PauseStart();
            Debug.Log("button pressed");

        }
        else if(Time.time <= 1 && Input.GetKeyDown(KeyCode.Tab))
        {

            Resume();

        }




    }
    public void Resume()
    {

        Time.timeScale = 1;
        if(_Player !=null)
        {
            GetComponent<Canvas>().enabled = false;
        }
        paused = false;
        timenumber = 0;

    }

    public void PauseStart()
    {

        Debug.Log("key imput working");
        paused = true;
        timenumber = 1;
        GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;

    }

}