using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player_H_bar : MonoBehaviour
{
    
    public int _HealthDisplay;
    public TextMeshProUGUI _HealthText;
    public Slider healthSlide;
    public Player_Controller player;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        
    }

    void Update()
    {
        
    }

    public void UpdateHealthAmount()
    {

        healthSlide.maxValue = player._Health;
        
    }
}
