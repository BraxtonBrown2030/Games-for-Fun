using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_V_Save : MonoBehaviour
{
    
    public AudioSource setVolume;
    public Slider musicslider;
    public float musicvolume;

    void Start()
    {
        
        musicvolume = musicslider.value;

    }

    
    public void Update()
    {
        
        UpdateMusicVolume();
       // Debug.Log(musicvolume);

       

    }

    public void UpdateMusicVolume()
    {

        musicvolume = musicslider.value;
        PlayerPrefs.SetFloat("music Volume", musicvolume);
        PlayerPrefs.GetFloat("music Volume", musicvolume);

        

    }

    public void SetFloat()
    {

        PlayerPrefs.SetFloat("music Volume", musicvolume);

    }

}
