using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMoment : MonoBehaviour
{

    [Header("Game Objects")]
    public GameObject[] points;
    public int curPointPlace;
    public int curPlayerMove;



    [Header("Sence Objects")]
    public Camera mainCamera;


    public float speed;

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
                
                points[curPointPlace].transform.position = myRayCastHit.point;
                curPointPlace += 1;

            }

        }

    }
    
    private void ResetPoints()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {

            curPointPlace = 0;

        }

    }


}
