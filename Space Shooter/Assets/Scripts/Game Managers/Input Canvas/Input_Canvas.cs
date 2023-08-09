using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Canvas : MonoBehaviour
{

    public Canvas popCanvas;
    public PowerPopUP powerpopUP;

    void Start()
    {
        Time.timeScale = 0;
        popCanvas.enabled = true;
        powerpopUP = GameObject.FindGameObjectWithTag("PopUpPowers").GetComponent<PowerPopUP>();

    }

    public void ClosePopUp()
    {
        
        popCanvas.enabled = false;
        Time.timeScale = 1;
        powerpopUP.isCanavas = false;

    }

    public void OpenGameMacanics()
    {

        popCanvas.enabled = true;
        powerpopUP.isCanavas = true;

    }
    public void CloseGameMacanicsP()
    {

        popCanvas.enabled = false;
        powerpopUP.isCanavas = false;

    }
}
