using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {


    public float Speed = 150f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -Speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Obstacle")
        {
            Destroy(gameObject);
            //FindObjectOfType<CameraShake>().StartCoroutine(FindObjectOfType<CameraShake>().ShakeCamera(0.2f, 0.3f));

        }
    }
}
