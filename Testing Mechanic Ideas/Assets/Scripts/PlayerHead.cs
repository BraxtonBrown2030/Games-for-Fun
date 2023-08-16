using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerHead : MonoBehaviour
{
    
    public GameObject marker;
    public float speed;
    public GameObject[] pBody;
    public bool isHead;

    void Start()
    {
        
        pBody = GameObject.FindGameObjectsWithTag("Player body");

    }


    void Update()
    {
        
        if(marker != null)
        {

            transform.position = Vector3.MoveTowards(transform.position, marker.transform.position, speed * Time.deltaTime);

        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "PlayerBody")
        {

            // send secen and show death screen

        }
        
        if(other.tag == "OuterWall")
        {

            //end game / show death screen

            Destroy(this.gameObject);
            isHead = false;
            


        }
        
        

    }

}
