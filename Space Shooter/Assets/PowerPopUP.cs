using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPopUP : MonoBehaviour
{

    public bool isCanavas;

    void Start()
    {
      isCanavas = GameObject.FindGameObjectWithTag("PopUP").GetComponent<Canvas>().enabled;
    }

    void Update()
    {
        
        if(isCanavas == false)
        {

            Destroy(gameObject);

        }



    }
}
