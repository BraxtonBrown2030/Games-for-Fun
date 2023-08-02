using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.PlayerLoop;
using UnityEngine.SocialPlatforms;

[CreateAssetMenu]
public class Musicvolume : ScriptableObject
{

    public float musicVoulumeFD;
    public SetVoume setVoume;


    public void UpdateMusic()
    {

        musicVoulumeFD = setVoume.musicvolume;

    }

    // set value of float to value of slider 
    // set value to vaul of music voulme




}
