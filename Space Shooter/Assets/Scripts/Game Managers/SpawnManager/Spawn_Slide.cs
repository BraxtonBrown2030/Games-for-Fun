using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Slide : MonoBehaviour
{
    
    [SerializeField] private GameObject slideEnemy;

    private Spawn_Manager spawn_Manager;
    private Wave_Manager wave_Manager;
    [SerializeField] private float _SpawnTimer = 1f;
    [SerializeField] private GameObject _SlideEnemy;
    private Player_Controller _Player;

    void Start()
    {
        
        spawn_Manager = GameObject.FindGameObjectWithTag("Spawn_Manager").GetComponent<Spawn_Manager>();
        wave_Manager = GameObject.FindGameObjectWithTag("Wave_Manager").GetComponent<Wave_Manager>();
        _Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
    }

    void Update()

    {
        
        if(_Player != null)
        {

        if(Time.time > _SpawnTimer && GameObject.FindGameObjectsWithTag("Slide_enemy").Length < spawn_Manager.maxSlide)
        {

             _SpawnTimer = Time.time + spawn_Manager._SpawnSpeed;

            Instantiate(_SlideEnemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);

        }

        }
    }
}
