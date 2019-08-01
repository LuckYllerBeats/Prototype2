using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotationMovement : MonoBehaviour {

    public KeyCode left;
    public KeyCode right;
    public float maxTimer = 0.5f;

    void Start()
    {

    }
    void Update()
    {

        if (Input.GetKey(left))
        {
            StartCoroutine(RotateObjectLeft());
        }

        else if (Input.GetKey(right))
        {
            StartCoroutine(RotateObjectRight());
        }
    }
    IEnumerator RotateObjectLeft()
    {
        float timer = 0f;
        while (timer <= maxTimer)
        {
            transform.Rotate(new Vector3(0, 0, 60) * Time.deltaTime);
            timer += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator RotateObjectRight()
    {
        float timer = 0f;
        while (timer <= maxTimer)
        {
            transform.Rotate(new Vector3(0, 0, -60) * Time.deltaTime);
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
