using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager instance;
    public bool redTouched;
    public bool blueTouched;
    public bool visible;
    public GameObject red;
    public GameObject blue;
    public GameObject GameLevel;
    float GameLevelSpeed;
    public float oriPos;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        oriPos = GameLevel.transform.position.y;
        instance = this;
        visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        redTouched = Red.instance.redTouched;
        blueTouched = Blue.instance.blueTouched;

        GameLevel.transform.position += new Vector3(0f, GameLevelSpeed * Time.deltaTime, 0f);

        if (redTouched == true || blueTouched == true)
        {
            GameLevelSpeed = 5f;

            if (GameLevel.transform.position.y < -2f)
            {
                visible = false;
                if (redTouched)
                {
                    red.SetActive(false);
                }
                else
                {
                    if (blueTouched)
                    {
                        blue.SetActive(false);
                    }
                }
            }
            else
            {
                visible = true;
                blue.SetActive(true);
                red.SetActive(true);
            }
        }
        else
        {
            GameLevelSpeed = -2.5f;
        }
    }
}