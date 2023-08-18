using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointMovemt : MonoBehaviour
{
 
    public PointMoment pmovment;
    public GameObject pointsToMove;
    public float speed = 4;


    void Start()
    {
        
        Time.timeScale = 0;

        pmovment = GameObject.FindGameObjectWithTag("MovePoint").GetComponent<PointMoment>();


    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Time.timeScale = 1;

        }

        if(Time.timeScale == 1)
        {

            Movement();

        }

    }

    void Movement()
    {

        transform.position = Vector3.MoveTowards(transform.position, pmovment.points[pmovment.curPlayerMove].transform.position, speed * Time.deltaTime);

    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "PlacePoint")
        {

            pmovment.curPlayerMove += 1;

        }


    }
}
