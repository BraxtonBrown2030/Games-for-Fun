using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpin : MonoBehaviour
{
    public float degreesPerSecond = 20;
    public float floatDistince = 2;

    [Header("Click movement")]
    [SerializeField]private Transform clickPostion;
    [SerializeField]private GameObject clickCube;
    public float moveSpeed;

    void Start()
    {
        // clickPostion = GameObject.FindGameObjectWithTag("Click Point").GetComponent<Transform>();
    }
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {

            // leftClick(0) rightClick(1) middleClick(2)

            Instantiate(clickCube, transform.position, Quaternion.identity);
            ClickMoverTowrds();

        }

        if(Input.GetKeyDown(KeyCode.G))
        {

           //RotateByDegree();

        }

        //transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime); // Rotate over a few seconds

    }
/*
    void RotateByDegree() // rotate on time on event
    {

        Vector3 roatioToAdd = new Vector3(0,90,0);
        transform.Rotate(roatioToAdd);

    }
*/

    void ClickMoverTowrds()
    {

        transform.position = Vector3.MoveTowards(transform.position, clickPostion.position, moveSpeed * Time.deltaTime);

    }

}
