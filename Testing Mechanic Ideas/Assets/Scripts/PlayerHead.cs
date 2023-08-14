using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "PlayerBody")
        {

            // send secen and show death screen

        }
        
        if(other.tag == "OuterWall")
        {

            //end game / show death screen

            Destroy(this.gameObject);


        }

    }

}
