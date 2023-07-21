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

        healthSlide.maxValue = 10;
        healthSlide.minValue = 0;
        
    }

    void Update()
    {
        UpdateHealthAmount();
    }

    public void UpdateHealthAmount()
    {

        healthSlide.value = player._Health;
        
    }
}
