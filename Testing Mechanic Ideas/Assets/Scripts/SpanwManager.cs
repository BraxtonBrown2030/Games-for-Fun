using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwManager : MonoBehaviour
{
    
    public GameObject apple;
    public GameObject player;

    public float curtime;
    public float spawnPostion;

    void Start()
    {

        apple = GameObject.FindGameObjectWithTag("apple");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        
        if(player != null)
        {

            Instantiate(apple, new Vector3(0,0,0) , Quaternion.identity);
            //                              X,Y,Z
        }

    }

    public void SpanwTimer()
    {



    }
}
