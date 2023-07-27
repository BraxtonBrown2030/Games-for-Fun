using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Timeline;

public class Slide_Enemy : MonoBehaviour
{

     [Header("Health")]
    private float _Health;

    [Header("movement / Attacks")]
    private int _Movespeed = -1;
    private float _Attackspeed = -0.5f;
    private float _LastAttackTime = 3f;
    public int scoreToGive;

    [Header("Scripts")]
    Spawn_Manager spawn_Manager;
    private Player_Controller playerscript;
    public Score_Manager scoremanager;
    public Wave_Manager wave_Manager;

    [Header("GameObjects")]
    [SerializeField] private GameObject _Lazer;

    void Start()
    {
        
        playerscript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        scoremanager = GameObject.FindGameObjectWithTag("Score_Manager").GetComponent<Score_Manager>();
        wave_Manager = GameObject.FindGameObjectWithTag("Wave_Manager").GetComponent<Wave_Manager>();
    }

    void Update()
    {
        
        Slide_Movement();

        if(Time.time > _Attackspeed)
        {

            Attack();

        }

        if(playerscript._Health <= 0)
        {


            Destroy(this.gameObject);

        }

    }

    private void OnTriggerEnter(Collider other)
    {

         if(other.tag == "Player")
        {
            Player_Controller player = other.transform.GetComponent<Player_Controller>();

            if(player != null)
            {
                player.TakeDamage();
            }

            Destroy(gameObject);

        }

        if(other.tag == "Laser")
        {
         
            Destroy(other.gameObject);
            wave_Manager.Killed();
            scoremanager.IncraseScoretect(scoreToGive);
            Destroy(this.gameObject);
        } 
        
    }

    void Slide_Movement()
    {

        transform.Translate(Vector3.up * Time.deltaTime * _Movespeed);


        if(transform.position.y <= -6.5) // reuse spawn that go off screen
        {
            float _randomRangeX = Random.Range(-9.5f, 10f);

            transform.position = new Vector3 (_randomRangeX,8,0);

        }

        if(transform.position.x >= -9.5f && transform.position.x <= 0f)
        {

            transform.Translate(Vector3.left * Time.deltaTime * _Movespeed);
            transform.Translate(Vector3.down * Time.deltaTime);

            if(transform.position.x <= 10f && transform.position.x >= 0f)
            {
             transform.Translate(Vector3.left * Time.deltaTime * _Movespeed);
             transform.Translate(Vector3.down * Time.deltaTime);
            }

        }

        else if(transform.position.x <= 10f && transform.position.x >= 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _Movespeed);
            transform.Translate(Vector3.down * Time.deltaTime);

            if(transform.position.x >= -9.5f && transform.position.x <= 0f)
            {   

                transform.Translate(Vector3.right * Time.deltaTime * _Movespeed);
                transform.Translate(Vector3.down * Time.deltaTime);

            }
        }

    }

    void Attack()
    {

        _Attackspeed = Time.time + _LastAttackTime;
        Instantiate(_Lazer, transform.position + new Vector3 (0,-0.8f, 0), Quaternion.identity);

    }
}
