using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsSlider : MonoBehaviour
{

    public Slider soundslider;

    void Start()
    {
        
        soundslider.GetComponent<Slider>();

    }


    void Update()
    {
        

    }

    public  void ChangeVolume()
    {

        AudioListener.volume = soundslider.value;
        Save();

    }

    private void Load()
    {

        soundslider.value = PlayerPrefs.GetFloat("sound volume");
        PlayerPrefs.SetFloat("sound volume" = soundslider);
    }

    private void Save()
    {

        PlayerPrefs.Save();    

    }

}
