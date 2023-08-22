using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] public ScoreManager score;
    [SerializeField] public SpanwManager spawn;

    [SerializeField] private float degreesPerSecond;

    public ScriptibleObjctTests sOT;

    void Start()
    {

        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        spawn = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpanwManager>();
    }

    void Update()
    {
        
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

        sOT.isStart = false;

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            score.IncreaseScore();
            Destroy(gameObject);
            spawn.SpanwTimer();

        }


    }

    /*
        instaniate body 
        change follow script to last section of body

    */

}