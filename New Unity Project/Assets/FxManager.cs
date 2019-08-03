using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxManager : MonoBehaviour {

    public GameObject bloodSpat;
    //public Transform obstacle;

    void OnTriggerEnter2D(Collider2D col)
    {
        //if the obstacle collides with the red or blue player: Spawn bloodSpat
        if(col.gameObject.tag == "Blue" || col.gameObject.tag == "Red")
        {
            Instantiate(bloodSpat, transform.position, Quaternion.identity);    //Instantiate blood on the Obstacle

            //bloodSpat.transform.SetParent(obstacle);        //was trying to parent bloodSpat parented to obstacle
        }
        
        


    }

}
