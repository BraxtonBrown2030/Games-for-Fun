using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBody : MonoBehaviour
{

    public bool isSwitch;
    //public GameObject laser;
    public Canvas gameEnd;

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

    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            Time.timeScale = 0;
            gameEnd.enabled = true;
            Destroy(other.gameObject);

        }


    }

}
