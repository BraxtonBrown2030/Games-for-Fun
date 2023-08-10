using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Slider slider;
    public float timer;
    public bool countdown;
    public bool timerStart;
    public float nextCountDown;

 void Start()
 {

    timerStart = false;

 }

 private void Update()
 {

    if(timerStart == true && slider.value >= 0)
    {
        timer = countdown ? timer -= Time.deltaTime : timer += Time.deltaTime;
        slider.value = timer;

        if(timer <= 0)
        {
            timerStart = false;
        }
        
    }
    else if(timerStart == false && slider.value <= 0)
    {

        timer = 7;
        slider.value = 7;
        slider.maxValue = 7;

    }


 }

}
