using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TImers : MonoBehaviour
{

    public Slider powerslider;
    public Player_Controller _player;

    void Start()
    {

        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();

    }

    void Update()
    {
        
    }

    public void SetPowerTimer()
    {

        powerslider.value = _player._Health; 

    }

}
