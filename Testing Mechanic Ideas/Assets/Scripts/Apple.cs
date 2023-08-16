using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] public ScoreManager score;
    [SerializeField] public SpanwManager spawn;

    [SerializeField] private float degreesPerSecond;

    void Start()
    {

        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        spawn = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpanwManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

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

}