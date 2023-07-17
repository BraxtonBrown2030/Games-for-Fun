using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
[Header("Health")]
public int _Health = 3;

[Header("Movment")]
public float _Speed;

[Header("Player Combat")]
[SerializeField] private float attackSpeed = -0.5f;
[SerializeField] private float lastAttackTime = 0.3f;
public int _Damage;
[SerializeField] GameObject laser;
[SerializeField] GameObject tripleShot;
public GameObject[] _player;
private bool istrippleshot = true;

    void Start()
    {
        


    }


    void Update()
    {
        Movment();

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > attackSpeed)
        {
            Attack();
        }
    }

    public void TakeDamage()
    {

        _Health -= 1;

        if(_Health < 1)
        {
            Destroy(this.gameObject);
        }

    }

    void Movment()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * _Speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * _Speed * Time.deltaTime);

        if(transform.position.y >= 0)
         {
             transform.position = new Vector3(transform.position.x,0,0);
         }
        else if(transform.position.y <= -3.8f)
         {
             transform.position = new Vector3(transform.position.x, -3.8f, 0);
         }

        if(transform.position.x >= 11)
         {
             transform.position = new Vector3(-11,transform.position.y,0);
         }
        else if (transform.position.x <=-11)
         {
             transform.position = new Vector3(11,transform.position.y,0);
         }

    }

    void Attack()
    {
        attackSpeed = Time.time + lastAttackTime;

        Instantiate(laser, transform.position + new Vector3(0,0.8f,0), Quaternion.identity);

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Enemy_Laser")
        {

            Destroy(other.gameObject);

        }


    }
}
