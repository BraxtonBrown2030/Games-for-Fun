using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ChangeVolume : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;

    void Awake()
    {

        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        

    }

    public void SetMusicVolume(float volumeSlider)
    {

        PlayerPrefs.SetFloat("MusicVolume", volumeSlider);


    }

}
