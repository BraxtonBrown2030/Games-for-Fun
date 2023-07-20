using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fall_Enemy : MonoBehaviour
{
    [Header("Movment")]
    [SerializeField]private int moveSpeed = -4;

    [Header("Attack")]
    public int _damage;
    public float _attackSpeed;
    public float _lastAttackTime;

    [Header("Health")]
    public int _totalHeath;
    public int _curHealth;

    [Header("Game_Objects")]
    public GameObject _LootDrops;
    public GameObject _TopEnemy;
    private Player_Controller playerscript;
    public Score_Manager _ScoreManager;
    public Wave_Manager wave_Manager;

    void Start()
    {
        
     playerscript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
     wave_Manager = GameObject.FindGameObjectWithTag("Wave_Manager").GetComponent<Wave_Manager>();
        
    }

    void Update()
    {

        Movement();

       if(playerscript._Health <= 0) // testing 7/16/2023
        {

            Destroy(this.gameObject);

        }

    }

    void Movement()
    {

        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);

        if(transform.position.y <= -6.5)
        {

            float _randomRangeX = Random.Range(-9.5f, 10f);

            transform.position = new Vector3 (_randomRangeX,8,0);

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

            Destroy(this.gameObject);

        }

        if(other.tag == "Laser")
        {

            Destroy(other.gameObject);
            wave_Manager.Killed();
            Destroy(this.gameObject);

        }

    }


}
