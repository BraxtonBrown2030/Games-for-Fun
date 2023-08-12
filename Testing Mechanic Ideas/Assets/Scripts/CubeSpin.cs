using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpin : MonoBehaviour
{
    
    public GameObject pointOfMove;

    public float degreesPerSecond = 20;
    public float floatDistince = 2;

    void Start()
    {
        pointOfMove = GameObject.FindGameObjectWithTag("Click Point").GetComponent<Transform>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.G))
        {

            RotateByDegree();

        }

        //transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, pointOfMove, floatDistince);

    }

    void RotateByDegree()
    {

        Vector3 roatioToAdd = new Vector3(0,90,0);
        transform.Rotate(roatioToAdd);

    }


}
