using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

  //this will be attached to the obstacles

    public float ObstacleSpeed = 2f;
    private float ObstOnScreen;
   
    void Start()
    {
      
       ObstOnScreen = -Camera.main.orthographicSize * transform.localScale.y;
    }

    void Update()
    {
        transform.Translate(0, -ObstacleSpeed * Time.deltaTime, 0);
    }
    void FixedUpdate()
    {
        
        if (transform.position.y < ObstOnScreen)
        {
            Destroy(gameObject);

        }
    }
 

}
