using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpin : MonoBehaviour
{
    
    public float degreesPerSecond = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.G))
        {

            RotateByDegree();

        }

        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

    }

    void RotateByDegree()
    {

        Vector3 roatioToAdd = new Vector3(0,90,0);
        transform.Rotate(roatioToAdd);

    }


}
