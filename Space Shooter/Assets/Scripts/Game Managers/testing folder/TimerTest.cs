using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTest : MonoBehaviour
{

    public Slider timerslider;
    public bool stopTimer;

    public float resetTime;

    void Start()
    {
        
        
        timerslider.maxValue = 7;

    }


    void Update()
    {

        if(stopTimer == false)
        {

            timerslider.value -= Time.time - 0.6f;

        }
        if(stopTimer == true)
        {

            timerslider.value = 7;

        }
        

    }
}
