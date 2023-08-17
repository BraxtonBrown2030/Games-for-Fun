using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AI;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovment : MonoBehaviour
{
    
    public NavMeshAgent playerNavMeshAgent;
    public Camera playerCamera;

    [Header("Speed changes")]
    public float newSpeed = 5;
    public float changeSpeed;

    public GameObject points;

    void Start()
    {
        
        //playerNavMeshAgent.speed = newSpeed;

    }

    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {

            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myrayCastHit;

            if(Physics.Raycast(myRay, out myrayCastHit))
            {

                Instantiate(points, myrayCastHit.point, Quaternion.identity);
                

            }

        }

    }
}
