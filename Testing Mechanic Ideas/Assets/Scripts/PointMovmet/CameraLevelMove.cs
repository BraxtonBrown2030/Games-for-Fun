using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CameraLevelMove : MonoBehaviour
{
    
    public Camera mainCamera;
    public int levelNumber;
    public Vector3 canemraPos;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    public void CameraMove()
    {

        if(levelNumber == 2)
        {

            transform.position = canemraPos;

        }

    }
}
