using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    public bool visible;
    public int counter;
    public float Speed = 150f;
    public float DeadSpeed = 150f;
    public int a;

    // Update is called once per frame
    void Update()
    {
        visible = GameManager.instance.visible;

        if (visible)
        {
            a = Mathf.Abs(counter);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0f, 0f, Speed * Time.deltaTime);
                counter++;
            }
            else
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Rotate(0f, 0f, -Speed * Time.deltaTime);
                    counter--;
                }
            }
        }
        else
        {

            transform.Rotate(0f, 0f, -DeadSpeed * Time.deltaTime);
        }
    }
}
