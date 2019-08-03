using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Play BG song when game starts
        FindObjectOfType<AudioManager>().Play("Theme Sound");
        FindObjectOfType<AudioManager>().Play("BG Sound");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<AudioManager>().Play("Obstacle Sound");
            //print("Played Obstacle Spawn Sound");
        }
    }
}
