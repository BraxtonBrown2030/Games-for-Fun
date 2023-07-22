using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class HealthRestore : MonoBehaviour
{

    public float moveSpeed;

    void Start()
    {
    
    }

    void Update()
    {
        
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);

        if(transform.position.y <= -6.5)
        {

            Destroy(gameObject);

        }
         if(transform.position.y <= 0)
        {

            moveSpeed = 1f;

        }


    }
}
