using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowScript : MonoBehaviour
{
    public GameObject player;
    public Transform followObject;
    public float speed;
    public float stopDistice = 4;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        FollowVoidPart();
        
    }

    public void FollowVoidPart()
    {

        
        if(player != null && Vector3.Distance(transform.position, followObject.position) > stopDistice)
        {

           transform.position = Vector3.MoveTowards(transform.position, followObject.position, speed * Time.deltaTime);

        }

    }

}
