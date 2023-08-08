using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public float timer;


 private void OnTriggerStay(Collider other)
 {

    timer += 1f * Time.deltaTime;

 }

private void Update()
{

    if(timer <= 0)
    {

        timer = 5f;

    }

}


}
