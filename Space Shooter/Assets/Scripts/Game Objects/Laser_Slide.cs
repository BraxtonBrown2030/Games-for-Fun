using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Slide : MonoBehaviour
{
    [SerializeField] private float _LaserSpeed = 2f;
        void Start()
    {
        
    }

    void Update()
    {

     transform.Translate(Vector3.down * _LaserSpeed * Time.deltaTime);

     if(transform.position.y < -8f)
     {

        Destroy(gameObject);

     }

    }

    private void OnTriggerEnter(Collider other)
    {
        Player_Controller player = other.transform.GetComponent<Player_Controller>();

        if(other.tag == "Player")
        {

            player.TakeDamage();
            Destroy(this.gameObject);

        }


    }
}
