using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowScript : MonoBehaviour
{
    public GameObject player;
    public Transform followObject;
    public float speed;
    public float stopDistice = 4;
    public PlayerHead playerHead;
    public GameObject pbody;
    public List<Transform> preObject;
    int pbodyindex;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHead = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHead>();

        preObject = new List<Transform>();
        preObject.Add(this.transform);

    }

    // Update is called once per frame
    void Update()
    {
        
        FollowVoidPart();

        if(playerHead.isHead == false)
        {

            Destroy(gameObject);

        }
        
    }

    public void FollowVoidPart()
    {

        
        if(player != null && Vector3.Distance(transform.position, followObject.position) > stopDistice)
        {

           transform.position = Vector3.MoveTowards(transform.position, followObject.position, speed * Time.deltaTime);

        }

    }

    public void BodyExpand()
    {

       // preObject.Add(preObject);
        //preObject.postion = preObject[preObject.Count - 1].position;


        
    }



}
