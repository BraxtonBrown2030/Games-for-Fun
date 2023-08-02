using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{

    public Timer timer;

    void Start()
    {
        
        timer = GameObject.FindGameObjectWithTag("Power Timer").GetComponent<Timer>();

    }

 
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.N))
        {

            timer.TimerReset();

        }

    }
}
