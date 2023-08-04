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

    public float timerTest;


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

        if(timerTest <= 0)
        {

            timerTest = 7;

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

    private void OnTriggerStay()
    {

        timerTest += 1f * Time.deltaTime;

    }


}
