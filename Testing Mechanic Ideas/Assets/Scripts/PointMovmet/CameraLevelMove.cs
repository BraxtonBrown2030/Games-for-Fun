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

    void Update()
    {
        
        

    }

    public void CameraMove()
    {

        transform.position = canemraPos;

    }
}
