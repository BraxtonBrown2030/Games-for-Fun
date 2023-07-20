using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Manager : MonoBehaviour
{
[Header("Spawn timers")]
[SerializeField] private float _SpawnTimer = 1f;
[SerializeField] private float _SpawnSpeed = 1f;

[Header("Game objects")]
[SerializeField] private GameObject _HealthPower;
[SerializeField] private GameObject _SpeedPower;
[SerializeField] private GameObject _TriplePower;

public GameObject[] _Powerups;

[Header("Spawn limit")]
public float numberOfPowerUps;

[Header("Scripts")]
private Player_Controller _Player;

    void Start()
    {
        
        _Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();

    }

    void Update()
    {
        
        if(_Player != null)
        {

            if(Time.time > _SpawnTimer && _Powerups.Length < numberOfPowerUps)
            {
                int powerIndex = Random.Range(0,_Powerups.Length);

                Instantiate(_Powerups[powerIndex], new Vector3(Random.Range(-9.5f ,10f), 8, 0), Quaternion.identity);

            }
            else
            {

                numberOfPowerUps = 0;

            }

        }


    }
}
