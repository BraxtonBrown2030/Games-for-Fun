using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Canvas : MonoBehaviour
{

    public Canvas popCanvas;
    public PowerPopUP powerpopUP;
    public PowerPopUP powerpopUPS;
    public PowerPopUP powerpopUPT;

    void Start()
    {
        Time.timeScale = 0;
        popCanvas.enabled = true;
        powerpopUP = GameObject.FindGameObjectWithTag("PopUpPowers").GetComponent<PowerPopUP>();
        powerpopUPS = GameObject.FindGameObjectWithTag("PopUpSpeed").GetComponent<PowerPopUP>();
        powerpopUPT = GameObject.FindGameObjectWithTag("PopUpTShot").GetComponent<PowerPopUP>();
    }

    public void ClosePopUp()
    {
        
        popCanvas.enabled = false;
        Time.timeScale = 1;
        powerpopUP.isCanavas = false;
        powerpopUPT.isCanavas = false;
        powerpopUPS.isCanavas = false;

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
        powerpopUPT.isCanavas = false;
        powerpopUPS.isCanavas = false;

    }
}
