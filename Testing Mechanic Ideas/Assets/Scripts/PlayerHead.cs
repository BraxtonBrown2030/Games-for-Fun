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
    public GameObject testingBody;
    public bool isHead;
    public FollowScript followScript;
    public Vector3 spawnPostion;

    void Start()
    {
        isHead = true;
        pBody = GameObject.FindGameObjectsWithTag("Player body");
        followScript = GameObject.FindGameObjectWithTag("Player body").GetComponent<FollowScript>();
        spawnPostion = new Vector3(Random.Range(0,0),1,Random.Range(0,0));

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
        if(other.tag == "Apple")
        {

            Instantiate(testingBody, spawnPostion, Quaternion.identity);
            
        }
        
        /*
            spawn boay 
            set unique number 
            change follow to number


        */

    }

}
