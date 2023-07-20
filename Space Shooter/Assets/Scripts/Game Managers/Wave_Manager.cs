using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Wave_Manager : MonoBehaviour
{
    
    public float wavecount;
    public float numberskilled;
    public float currentnumber;

    void Start()
    {

    

    }

    void Update()
    {

        if(numberskilled >= 20)
        {

            wavecount = currentnumber / 20;
            Debug.Log(wavecount);

        }


    }

    public void Killed()
    {

        numberskilled += 1;
        Debug.Log(numberskilled);
        currentnumber = numberskilled;

    }
}
