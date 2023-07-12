using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.Timeline;

public class Player_Controller : MonoBehaviour
{
    
    [Header("momvment")]
    private float _Himput;
    private float _Vimput;

    [SerializeField]
    private float _Moverspeed;
    private float _Turnspeed;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("game is running");

        if(Input.GetMouseButton(0))
        {
            Attack();
        }
    
    }

    public void Attack()
    {
        
    }
}
