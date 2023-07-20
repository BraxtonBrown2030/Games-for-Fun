using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline;
using UnityEngine;

public class Wave_Manager : MonoBehaviour
{
    
    public float wavecount;
    public float numberskilled;
    public float currentnumber;
    public float waveNumber;

    public TextMeshProUGUI waveText;

    void Start()
    {

        UpdateWaveText();
        wavecount = 1;

    }

    void Update()
    {

        if(numberskilled >= 20 && waveNumber == 1)
        {

            waveNumber += 1;

            Debug.Log("wave" + waveNumber);

        }
        if(numberskilled >= 40 && waveNumber == 2)
        {

            waveNumber += 1;
            Debug.Log("wave" + waveNumber);

        }
        if(numberskilled >= 60 && waveNumber == 3)
        {

            waveNumber += 1;
            Debug.Log("wave" + waveNumber);

        }
        if(numberskilled >= 80 && waveNumber == 4)
        {
            Debug.Log("wave" + waveNumber);
            waveNumber += 1;
        }
        if(numberskilled >= 100 && waveNumber == 5)
        {
            Debug.Log("wave" + waveNumber);
            waveNumber += 1;
        }


    }

    public void Killed()
    {

        numberskilled += 1;
        Debug.Log(numberskilled);
        currentnumber = numberskilled;

    }

    public void UpdateWaveText()
    {

        waveText.text = "Wave: " + waveNumber;

    }

}
