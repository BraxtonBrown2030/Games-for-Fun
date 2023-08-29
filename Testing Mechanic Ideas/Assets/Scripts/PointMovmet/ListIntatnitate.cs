using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ListIntatnitate : MonoBehaviour
{
    
    List<GameObject> listOfPoints = new List<GameObject>();
    public GameObject point;
    public float numberOfPoints;
    public int levelPointLimit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Input.GetMouseButtonDown(1) && listOfPoints.Count == levelPointLimit)
       {

            listOfPoints.Add(Instantiate(point, listOfPoints[0].transform.position, listOfPoints[0].transform.rotation) as GameObject);

       }
    
        

    }

}
