using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Slider timerSlider;
    public float  gameTime;
    public bool stoptimer;

    public float resetTime;

    

    void Start()
    {
        
        stoptimer = true;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;

    }


    void Update()
    {
        

        if(stoptimer == false)
        {
           // this.gameObject.SetActive(true);
            StartCountDown();

        }
        if(stoptimer == true)
        {

            //this.gameObject.SetActive(false);
            timerSlider.value = 7;

        }


    }

    public void StartCountDown()
    {

        float time = gameTime - Time.time;
        

        if(time <= 0)
        {

            stoptimer = true;

        }
        if(stoptimer == false)
        {
            
            timerSlider.value = time;

        }

    }

    public void TimerReset()
    {

        timerSlider.value = 7;

    }
}
