using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeHolder : MonoBehaviour {

    public static placeHolder instance;
    public bool a;

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Red" || col.gameObject.tag == "Blue")
        {
            a = true;
            Debug.Log("Touched1");
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Red" || col.gameObject.tag == "Blue")
        {
            a = false;
            Debug.Log("Touched1");
        }
    }
}
