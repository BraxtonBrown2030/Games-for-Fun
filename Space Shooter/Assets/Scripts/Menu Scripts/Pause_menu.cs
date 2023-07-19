using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pause_menu : MonoBehaviour
{
    private Player_Controller _Player;

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
        }

    }
    public  void Resume()
    {

        Time.timeScale = 1;
        if(_Player !=null)
        {
            GetComponent<Canvas>().enabled = false;
        }

    }

    public void PauseStart()
    {

        Debug.Log("key imput working");
        GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;

    }
}