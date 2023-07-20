using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrippleLaser : MonoBehaviour
{
    
    public float moveSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 6.5)
        {

            Destroy(gameObject);

        }

        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);

    }
}
