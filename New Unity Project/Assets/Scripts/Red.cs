using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{

	public static Red instance;
    public bool redTouched;
    public bool goBack;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        goBack = GameManager.instance.visible;
        if (goBack)
        {
            //redTouched = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
      
            redTouched = true;
        }
    }
}