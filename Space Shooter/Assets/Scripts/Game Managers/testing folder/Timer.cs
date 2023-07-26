using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Slider timerSlider;
    public float  gameTime;

    private bool stopTimer;

    void Start()
    {
        
        stopTimer = false;
        timerSlider.maxValue = 7;
        timerSlider.value = gameTime;

    }


    void Update()
    {
        
        float time = gameTime -Time.time;
        
        int minuets = Mathf.FloorToInt(time/60);
        int seconds = Mathf.FloorToInt(time - minuets * 60);

        if(time <= 0)
        {

            stopTimer = true;

        }

    }
}
