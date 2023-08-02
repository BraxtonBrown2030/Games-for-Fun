using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVoume : MonoBehaviour
{
    
    public float musicvolume;

    void Start()
    {
        
        musicvolume = this.GetComponent<AudioSource>().volume;

    }

    
    void Update()
    {


        Debug.Log(musicvolume);

    }
}
