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



 }

 private void Update()
 {

    if(timerStart == true && slider.value >= 0)
    {
        timer = countdown ? timer -= Time.deltaTime : timer += Time.deltaTime;
        slider.value = timer;
    }
    else if(timerStart == false && slider.value <= 0)
    {

        timer = nextCountDown;

    }


 }

}
