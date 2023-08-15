using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickMovement : MonoBehaviour
{
    
    public Camera pcam;
    public GameObject marker;
    public GameObject[] makerArray;



    void Start()
    {
        

        /*
        make mouse spawn point
        make player move to point 
        destroy the marker 
        when player lets go off mouse player stops


        */
    }


    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {

            Ray myray = pcam.ScreenPointToRay(Input.mousePosition);
            RaycastHit myraycasthit;

            if(Physics.Raycast(myray, out myraycasthit))
            {

             //   Instantiate(marker, new Vector3(), Quaternion.identity);
                            

            }

        }

    }
}
