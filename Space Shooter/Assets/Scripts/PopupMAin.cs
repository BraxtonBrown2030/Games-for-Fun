using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupMAin : MonoBehaviour
{
    
    public Canvas popUpMain;
    public Canvas mainMenu;




    void Start()
    {
        
        popUpMain.enabled = false;

    }


    void Update()
    {
        
    }

    public void CloseWindow()
    {

        popUpMain.enabled = false;
        mainMenu.enabled = true;

    }

    public void OpenMenu()
    {

        popUpMain.enabled = true;
        mainMenu.enabled = false;

    }
}
