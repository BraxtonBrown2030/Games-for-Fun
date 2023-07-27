using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Slider timerSlider;
    public float  gameTime;
    public bool stoptimer;

    

    void Start()
    {
        
        stoptimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;

    }


    void Update()
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
}
