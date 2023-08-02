using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Test : MonoBehaviour
{
 
    public Slider timerslider;
    public float gameTime;
    public bool startTimer;
    public bool powerUpActive;


    void Start()
    {
        
        powerUpActive = false;

    }

    void Update()
    {
        
        if(startTimer == true && powerUpActive == true)
        {

            StartcountDown();

        }
        if(startTimer == false)
        {

            TimerReset();

        }

    }
    public void StartcountDown()
    {
        float time = gameTime - Time.time;

        if(time <= 0)
        {

            startTimer = false;

        }

    }

    public void TimerReset()
    {

        timerslider.value = gameTime + 7 - Time.time;

    }
}
