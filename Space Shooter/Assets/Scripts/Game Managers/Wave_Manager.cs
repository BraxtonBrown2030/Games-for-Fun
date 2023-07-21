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
    public Spawn_Manager spawn_Manager;

    void Start()
    {

        spawn_Manager = GameObject.FindGameObjectWithTag("Spawn_Manager").GetComponent<Spawn_Manager>();

        UpdateWaveText();
        wavecount = 1;

    }

    void Update()
    {

        if(numberskilled >= 20 && waveNumber == 1)
        {

            spawn_Manager.maxNumberOfEmenys = 4;
            spawn_Manager.maxSlide = 2;
            spawn_Manager.maxtop= 0;

            waveNumber += 1;

            Debug.Log("wave" + waveNumber);

        }
        if(numberskilled >= 40 && waveNumber == 2)
        {

            waveNumber += 1;
            Debug.Log("wave" + waveNumber);

            spawn_Manager.maxNumberOfEmenys = 6;
            spawn_Manager.maxSlide = 4;
            spawn_Manager.maxtop= 1;

        }
        if(numberskilled >= 60 && waveNumber == 3)
        {

            waveNumber += 1;
            Debug.Log("wave" + waveNumber);

            spawn_Manager.maxNumberOfEmenys = 8;
            spawn_Manager.maxSlide = 6;
            spawn_Manager.maxtop= 1;

        }
        if(numberskilled >= 80 && waveNumber == 4)
        {
            Debug.Log("wave" + waveNumber);
            waveNumber += 1;

            spawn_Manager.maxNumberOfEmenys = 10;
            spawn_Manager.maxSlide = 8;
            spawn_Manager.maxtop= 1;
        }
        if(numberskilled >= 100 && waveNumber == 5)
        {
            Debug.Log("wave" + waveNumber);
            waveNumber += 1;

            spawn_Manager.maxNumberOfEmenys = 12;
            spawn_Manager.maxSlide = 10;
            spawn_Manager.maxtop= 1;
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
