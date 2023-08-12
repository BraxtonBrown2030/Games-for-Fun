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

    void Start()
    {
        
        //playerNavMeshAgent.speed = newSpeed;

    }

    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {

            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myrayCastHit;

            if(Physics.Raycast(myRay, out myrayCastHit))
            {

                playerNavMeshAgent.SetDestination(myrayCastHit.point);       

            }

        }
    }
}
