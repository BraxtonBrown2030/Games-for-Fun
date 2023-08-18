using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointReset : MonoBehaviour
{
    
    public Vector3 resetPostion;

    void Start()
    {
        
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.R))
        {

            transform.position = resetPostion;

        }


    }
}
