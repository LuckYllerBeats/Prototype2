using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXTest : MonoBehaviour {

    public GameObject bloodFX;
    public GameObject bloodTrailFX;
 
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            //Play Sound & INstantiate particles
            Instantiate(bloodFX, transform.position, Quaternion.identity);      //Instantiate bloodFX from the position of contact
            Instantiate(bloodTrailFX, new Vector3(0, -2, 0), Quaternion.identity); //Instantiate bloodFX (Transform.pos or Vector?)
        }
    }
}
