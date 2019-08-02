using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    public bool visible;
    public float Speed = 150f;
    public float DeadSpeed = 150f;
    public float oriPos;
    public bool al;

    public GameObject placeHolder;

    void Start()
    {
        oriPos = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        visible = GameManager.instance.visible;
        //al = placeHolder.instance.a;

        if (visible)
        {
            //placeHolder.SetActive(false);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0f, 0f, Speed * Time.deltaTime);
            }
            else
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Rotate(0f, 0f, -Speed * Time.deltaTime);
                }
            }
        }
        else
        {
           // placeHolder.SetActive(true);
            
            if(al)
            {
                transform.Rotate(0f, 0f, -DeadSpeed * Time.deltaTime);
            }
        }
    }
}
