using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;
using UnityEngine;

public class Testing : MonoBehaviour
{
    
    public int[] numbers = {23,46,77,10,42,98,63,81};
    public float timeys;
    public bool attack;

    public Player_Controller player_Controller;


    void Start()
    {
        
       attack = gameObject.GetComponent<Player_Controller>().Attack();

    foreach(int numbers in numbers)
    {

        Debug.Log(numbers);

    }

    
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if()
        {


        }


    }
}
