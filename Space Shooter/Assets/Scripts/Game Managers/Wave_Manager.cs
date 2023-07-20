using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Wave_Manager : MonoBehaviour
{
    
    public float wavecount;
    public float numberskilled;
    public float currentnumber;
    public float waveNumber;

    void Start()
    {

    

    }

    void Update()
    {

        if(numberskilled >= 20 && waveNumber == 0)
        {

            wavecount = currentnumber / 20;


            waveNumber += 1;

            Debug.Log(wavecount);

        }
        if(numberskilled >= 40 && waveNumber == 1)
        {

            waveNumber += 1;

        }
        if(numberskilled >= 60 && waveNumber == 2)
        {

            waveNumber += 1;
        }
        if(numberskilled >= 80 && waveNumber == 3)
        {

            waveNumber += 1;
        }
        if(numberskilled >= 100 && waveNumber == 4)
        {

            waveNumber += 1;
        }


    }

    public void Killed()
    {

        numberskilled += 1;
        Debug.Log(numberskilled);
        currentnumber = numberskilled;

    }
}
