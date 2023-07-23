using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MMCanvas : MonoBehaviour
{

    public bool mainSetting;
    public bool mainPage;

    public Canvas mmSettings;
    public Canvas mmStart;

    void Start()
    {
        
        mmStart = GameObject.FindGameObjectWithTag("MM Start").GetComponent<Canvas>();
        mmSettings = GameObject.FindGameObjectWithTag("MM Settings").GetComponent<Canvas>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
