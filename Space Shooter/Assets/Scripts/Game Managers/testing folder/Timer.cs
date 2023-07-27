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
        

        if(stoptimer == false)
        {
            this.gameObject.SetActive(true);
            StartCountDown();

        }
        if(stoptimer == true)
        {

            this.gameObject.SetActive(false);
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
}
