using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Top_Enemy : MonoBehaviour
{
    [Header("Health")]
    public float health;
    [SerializeField] private GameObject healthDrop;
    
    private Transform player;
    private Player_Controller playerscript;
    public float _StopDistance = 7;
    public float _Speed = 2;
    public GameObject _Laser;
    public float _Attackspeed = -1f;
    public float _LastAttackTime = 1f;
    public Score_Manager scoreManager;
    public Wave_Manager wave_Manager;

    public int scoreToGive;

    void Start()
    {
        
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    playerscript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
    wave_Manager = GameObject.FindGameObjectWithTag("Wave_Manager").GetComponent<Wave_Manager>();
    scoreManager = GameObject.FindGameObjectWithTag("Score_Manager").GetComponent<Score_Manager>();

    }


    void Update()
    {
        

       if(player != null)
       { 
        if(Vector3.Distance(transform.position, player.position) > _StopDistance) // fllowing
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, _Speed * Time.deltaTime);
        }
        
        if(transform.position.y <= 5.5f) // downward barrirer
        {

            transform.position = new Vector3(transform.position.x,5.5f,0);

        }

        if( Time.time >= _Attackspeed)
        {

            Attack();

        }
       }
        if(playerscript._Health <= 0) // testing 7/16/2023
        {

            Debug.Log("Game end Destoy(top)");
            Destroy(gameObject);

        }
       
    }

    void Attack()
    {

        _Attackspeed = Time.time + _LastAttackTime;

        Instantiate(_Laser, transform.position + new Vector3(0,-0.8f,0), Quaternion.identity);

    }

    private void OnTriggerEnter(Collider other)
    {
;

        if(other.tag == "Player")
        {
            Player_Controller player = other.transform.GetComponent<Player_Controller>();

            if(player != null)
            {
                player.TakeDamage();
            }

            Destroy(this.gameObject);

        }

        if(other.tag == "Laser")
        {

            SpawnDrop();
            Destroy(other.gameObject);
            wave_Manager.Killed();
            scoreManager.IncraseScoretect(scoreToGive);
            Destroy(this.gameObject);

        }


    }

    private void SpawnDrop()
    {

        Instantiate( healthDrop, transform.position, Quaternion.identity);
        Debug.Log("drop working");

    }
    
}
