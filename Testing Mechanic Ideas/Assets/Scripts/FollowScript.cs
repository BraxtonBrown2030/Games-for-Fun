using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowScript : MonoBehaviour
{
    public Transform player;
    public Transform followObject;
    public float speed;
    public float stopDistice;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        FollowVoidPart();
        
    }

    public void FollowVoidPart()
    {

        
        if(player != null)
        {

            Vector3.MoveTowards(transform.position, followObject.position, speed * Time.deltaTime);

        }
        else
        {

            Destroy(this.gameObject);

        }
        

    }

}
