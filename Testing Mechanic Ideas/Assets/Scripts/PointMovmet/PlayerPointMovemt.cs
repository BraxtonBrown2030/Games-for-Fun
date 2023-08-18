using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointMovemt : MonoBehaviour
{
 
    public GameObject[] points;
    public PointMoment pmovment;
    public GameObject pointsToMove;
    public float speed;


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
            Movment();

        }

    }

    void Movment()
    {

        transform.position = Vector3.MoveTowards(transform.position, points[pmovment.curPlayerMove].transform.position, speed * Time.deltaTime);

    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "MovePoint")
        {

            pmovment.curPointPlace += 1;

        }


    }
}
