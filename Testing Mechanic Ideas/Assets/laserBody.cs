using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBody : MonoBehaviour
{

    public bool isSwitch;
    //public GameObject laser;

    void Start()
    {
        
        isSwitch = true;

    }


    void Update()
    {
        


        if(isSwitch == false)
        {

            this.gameObject.SetActive(false);

        }

        if(isSwitch == true)
        {

            this.gameObject.SetActive(true);

        }



    }
}
