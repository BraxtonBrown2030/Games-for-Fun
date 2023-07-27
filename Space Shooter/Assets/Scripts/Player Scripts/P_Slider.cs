using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_Slider : MonoBehaviour
{
    public float curTimer;
    public float maxtimer;
    public float mintimer;
    public float timerdecrese = 0.1f;
    public Player_Controller player;
    public Slider timeslider;


    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        timeslider.maxValue = 7;
        timeslider.minValue = 0;
        timeslider = GetComponent<Slider>();
    

    }


    void Update()
    {
        
        UpdateTimerSetttings();
         if(timeslider.value >= -1)
        {

            UpdateTimerSetttings();

        }

    }

    public void UpdateTimerSetttings()
    {


        if(player.istrippleshot == true)
        {

            curTimer -= timerdecrese * Time.deltaTime;

            if(curTimer <= mintimer)
            {

                curTimer = maxtimer;

            }


        }


    }
}
