using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Player : MonoBehaviour
{
    
    [SerializeField] private float _LazerSpeed = 8;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * _LazerSpeed * Time.deltaTime);

        if(transform.position.y >8f)
        {

            if(transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }

            Destroy(gameObject);

        }


    }
}
