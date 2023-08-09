using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerPopUP : MonoBehaviour
{

    public bool isCanavas;
    public GameObject[] powerPopUPS;

    void Start()
    {
      isCanavas = GameObject.FindGameObjectWithTag("PopUP").GetComponent<Canvas>().enabled;
    

    }

    void Update()
    {
        
        if(isCanavas == false)
        {

            Destroy(this.gameObject);
            gameObject.SetActive(false);

        }

    }

}
