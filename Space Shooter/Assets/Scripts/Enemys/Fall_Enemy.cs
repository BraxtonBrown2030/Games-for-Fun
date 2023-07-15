using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

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


    void Start()
    {
        
    }

    void Update()
    {

        Movement();

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

        Debug.Log("HIT:  " + other.transform.name);

        if(other.tag == "Player")
        {
            Player_Controller player = other.transform.GetComponent<Player_Controller>();

            if(player != null)
            {
                player.TakeDamage();
            }

        }

        if(other.tag == "Lazer")
        {

            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }

    }


}
