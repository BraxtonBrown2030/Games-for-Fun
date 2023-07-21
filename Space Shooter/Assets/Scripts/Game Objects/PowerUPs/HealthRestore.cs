using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class HealthRestore : MonoBehaviour
{

    public float movespeed;

    void Start()
    {
    
    }

    void Update()
    {
        
        transform.Translate(Vector3.down * Time.deltaTime * movespeed);

        if(transform.position.y <= -6.5)
        {

            Destroy(gameObject);

        }


    }
}
