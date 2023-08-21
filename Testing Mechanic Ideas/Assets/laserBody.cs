using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBody : MonoBehaviour
{

    public bool isSwitch;
    public GameObject laser;

    void Start()
    {
        
        isSwitch = true;

    }


    void Update()
    {
        


        if(isSwitch == false)
        {

            laser.SetActive(false);

        }

        if(isSwitch == true)
        {

            laser.SetActive(true);

        }



    }
}
