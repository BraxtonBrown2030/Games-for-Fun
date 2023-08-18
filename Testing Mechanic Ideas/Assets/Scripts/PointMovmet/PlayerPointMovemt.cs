using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointMovemt : MonoBehaviour
{
 
    public GameObject points;
    public PointMoment pmovment;
    public GameObject pointsToMove;


    void Start()
    {
        
        Time.timeScale = 0;

        pmovment = GameObject.FindGameObjectWithTag("Points").GetComponent<PointMoment>();

    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Time.timeScale = 1;

        }

    }

    void Movmeent()
    {

        

    }
}
