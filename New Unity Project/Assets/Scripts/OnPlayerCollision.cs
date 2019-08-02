using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerCollision : MonoBehaviour{


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }

}

