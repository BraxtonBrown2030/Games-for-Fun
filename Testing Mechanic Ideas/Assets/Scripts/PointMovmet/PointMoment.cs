using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMoment : MonoBehaviour
{

    [Header("Game Objects")]
    public GameObject[] points;
    public int curPoint;



    [Header("Sence Objects")]
    public Camera mainCamera;


    void Start()
    {
        
    }


    void Update()
    {

        MovePoint();

    }

    private void MovePoint()
    {


        if(Input.GetMouseButtonDown(0))
        {

            Ray myRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRayCastHit;

            if(Physics.Raycast(myRay, out myRayCastHit))
            {
                
                points[curPoint].transform.position = myRayCastHit.point;
                curPoint += 1;

            }

        }

    }
    
    private void ResetPoints()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {

            curPoint = 0;

        }

    }

}
