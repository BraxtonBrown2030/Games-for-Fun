using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{

    public Timer timer;

    void Start()
    {
        
    }

 
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.N))
        {

            Instantiate(timer);

        }
        if(timer.timerSlider.value == 0)
        {

            Destroy(timer);

        }

    }
}
