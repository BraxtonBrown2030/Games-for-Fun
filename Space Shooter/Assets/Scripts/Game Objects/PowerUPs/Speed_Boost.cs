using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Boost : MonoBehaviour
{

    public float movepseed;

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

        transform.Translate(Vector3.down * Time.deltaTime * movepseed);

    }
}
