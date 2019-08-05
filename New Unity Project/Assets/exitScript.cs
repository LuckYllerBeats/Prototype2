using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour {

    public GameObject exitoptionpic;
    public KeyCode esc, up, down;

	// Use this for initialization
	void Start () {

        exitoptionpic.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(esc))
        {
            exitoptionpic.gameObject.SetActive(true);
        }

        if (Input.GetKey(up))
        {
            exitoptionpic.gameObject.SetActive(false);
        }

        if (Input.GetKey(down))
        {
            exitoptionpic.gameObject.SetActive(false);
            Application.Quit();
        }
    }
}
