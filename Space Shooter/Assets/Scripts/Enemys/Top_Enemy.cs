using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Top_Enemy : MonoBehaviour
{
    [Header("Health")]
    public float health;
    
    private Transform player;
    public float _StopDistance = 7;
    public float _Speed = 2;

    void Start()
    {
        
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }


    void Update()
    {
        
        if(Vector3.Distance(transform.position, player.position) > _StopDistance) // fllowing
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, _Speed * Time.deltaTime);
        }
        
        if(transform.position.y <= 5.5f) // downward barrirer
        {

            transform.position = new Vector3(transform.position.x,5.5f,0);

        }

    }
}
