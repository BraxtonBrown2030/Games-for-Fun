using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Instrustions : MonoBehaviour
{
    public Canvas popUPInsturctions;
    
    public TMP_Text placePoints;
    public TMP_Text gameRunning;

    void Start()
    {
        
        popUPInsturctions.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePopUp()
    {


        popUPInsturctions.enabled = false;

    }
}
