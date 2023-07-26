using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu]
public class SO_V_Save : ScriptableObject
{
    
    public float savedMusicVolume;
    public Main_V_Save main_V_Save;

    public float savedhealth;
    

    void Start()
    {
        //Main menu saved volume - and refrence
        main_V_Save = GameObject.FindGameObjectWithTag("Main_V_Save").GetComponent<Main_V_Save>();
        savedMusicVolume = main_V_Save.musicvolume;

        //Game menu saved vould - Frefence



    }

    void Update()
    {
        
        savedMusicVolume = main_V_Save.musicvolume;
        Debug.Log("SO_V: " + savedMusicVolume);

        savedhealth = PlayerPrefs.GetFloat("music volume"); 

    }
}
