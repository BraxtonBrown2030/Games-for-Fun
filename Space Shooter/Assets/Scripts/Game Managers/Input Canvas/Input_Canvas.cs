using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Canvas : MonoBehaviour
{

    public Canvas popCanvas;

    void Start()
    {
        
        popCanvas.enabled = true;

    }

    public void ClosePopUp()
    {
        
        popCanvas.enabled = false;

    }
}
