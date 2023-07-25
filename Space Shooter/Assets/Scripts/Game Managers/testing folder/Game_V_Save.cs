using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Game_V_Save : MonoBehaviour
{
    
    public AudioSource setVolumeG;
    public Slider sliderG;
    public float musicvolumeG;

    void Start()
    {
        
        musicvolumeG = sliderG.value;

        

    }

    void Update()
    {

        if(sliderG.value >= -1)
        {

            UpdateMusicVolume();

        }


    }

    private void Awake()
    {

        UpdateMusicVolume();

    }

    public void UpdateMusicVolume()
    {

        musicvolumeG = sliderG.value;
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("music Volume", musicvolumeG);
        PlayerPrefs.GetFloat("music Volume", musicvolumeG);

    }

}
