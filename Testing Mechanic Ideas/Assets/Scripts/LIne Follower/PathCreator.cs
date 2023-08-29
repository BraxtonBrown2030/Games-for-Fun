using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;

public class PathCreator : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private List<Vector3> points = new List<Vector3>();
    public Action<IEnumerable<Vector3>> OnNewPathCreated = delegate { };

    private void Awake()
    {

        lineRenderer = GetComponent<LineRenderer>();

    }

    void Start()
    {
        



    }

    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {

            points.Clear();

        }

        if(Input.GetButton("Fire1"))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if(Physics.Raycast(ray, out hitInfo)) // try layermask
            {

                points.Add(hitInfo.point);

                lineRenderer.positionCount = points.Count;
                lineRenderer.SetPositions(points.ToArray());
                

            }

        }
        else if (Input.GetButtonUp("Fire1"))
        {
            OnNewPathCreated(points);
        }

    }

}