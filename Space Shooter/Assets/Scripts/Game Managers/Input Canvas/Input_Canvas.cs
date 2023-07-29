using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Canvas : MonoBehaviour
{

    public Canvas popCanvas;

    void Start()
    {
        Time.timeScale = 0;
        popCanvas.enabled = true;

    }

    public void ClosePopUp()
    {
        
        popCanvas.enabled = false;
        Time.timeScale = 1;

    }

    public void OpenGameMacanics()
    {

        popCanvas.enabled = true;

    }
    public void CloseGameMacanicsP()
    {

        popCanvas.enabled = false;

    }
}
