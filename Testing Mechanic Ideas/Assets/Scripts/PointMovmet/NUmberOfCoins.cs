using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NUmberOfCoins : MonoBehaviour
{
    
    public ScriptibleObjctTests sOT;
    public TextMeshProUGUI coinNumber;
    public int coinNumberS;


    void Start()
    {
        coinNumber.text = "number of coins" + sOT.coins;

    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
