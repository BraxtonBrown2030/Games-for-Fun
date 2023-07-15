using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private float _SpawnTimer = 1f;
    [SerializeField] private float _SpawnTimertop = 5;
    [SerializeField] private float _SpawnSpeed = 1f;

    [Header("Game Objects")]
    [SerializeField] private GameObject _FallEnemy;
    [SerializeField] private GameObject _SlideEnemy;
    [SerializeField] private GameObject _TopEnemy;

    [Header("Number of enemys")]
    public float maxNumberOfEmenys;
    public float maxSlide;
    public float maxtop;
    private Player_Controller _Player;


    void Start()
    {
        
    }

    void Update()
    {

        if (Time.time > _SpawnTimer && GameObject.FindGameObjectsWithTag("Enemy").Length < maxNumberOfEmenys)
        {
            _SpawnTimer = Time.time + _SpawnSpeed;

            Instantiate(_FallEnemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);

        }

        if(Time.time > _SpawnTimer && GameObject.FindGameObjectsWithTag("Slide_enemy").Length < maxSlide)
        {
            _SpawnTimer = Time.time + _SpawnSpeed;

            Instantiate(_SlideEnemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);
        }



    }
}
