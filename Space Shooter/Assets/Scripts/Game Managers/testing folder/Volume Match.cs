using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class VolumeMatch : MonoBehaviour
{
    public AudioSource v_Music;
    public Slider slider;

    public float slidervalue;
    public float setvaule;


    void Start()
    {

        v_Music = GameObject.FindGameObjectWithTag("Main Music").GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        


    }
}
