using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour {

    public GameObject obone, obtwo, obthree, obfour, rules;
    public KeyCode left, right;


	// Use this for initialization
	void Start () {
        obone.gameObject.SetActive(false);
        obtwo.gameObject.SetActive(false);
        obthree.gameObject.SetActive(false);
        obfour.gameObject.SetActive(false);
        rules.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(left))
        {
            obone.gameObject.SetActive(true);
            obtwo.gameObject.SetActive(true);
            obthree.gameObject.SetActive(true);
            obfour.gameObject.SetActive(true);
            rules.gameObject.SetActive(false);

        }

        if (Input.GetKey(right))
        {
            obone.gameObject.SetActive(true);
            obtwo.gameObject.SetActive(true);
            obthree.gameObject.SetActive(true);
            obfour.gameObject.SetActive(true);
            rules.gameObject.SetActive(false);

        }

    }
}
