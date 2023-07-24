using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Volume : ScriptableObject
{
    
    public AudioSource mainmusic;
    public float m_mainmusic;
    

    void Start()
    {

        mainmusic = GameObject.FindGameObjectWithTag("Main Music").GetComponent<AudioSource>();


    }

    void Update()
    {
        
        mainmusic.volume = m_mainmusic;

    }
}
