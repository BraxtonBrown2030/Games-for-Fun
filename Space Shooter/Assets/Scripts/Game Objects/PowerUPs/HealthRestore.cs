using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRestore : MonoBehaviour
{

    public GameObject[] store_powerups;

    void Start()
    {
        
    }

    void Update()
    {
        
        if(transform.position.y <= 6.5 && transform.position.x <= -10)
        {
            int powerups = Random.Range(0,store_powerups.Length);

            transform.position = new Vector3 store_powerups[powerups];

        }


    }
}
