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
        
        if(transform.position.y <= 6.5)
        {

            Destroy(gameObject);

        }

        transform.Translate(Vector3.down * Time.deltaTime * movespeed);


    }
}
