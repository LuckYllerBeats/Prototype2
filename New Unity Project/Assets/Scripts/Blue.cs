using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{

	public static Blue instance;
    public bool blueTouched;
    public bool goBack;

    public GameObject deathFX;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        StopCoroutine("Delay"); 
    }

    // Update is called once per frame
    void Update()
    {
        goBack = GameManager.instance.visible;
        if (goBack && blueTouched)
        {
            blueTouched = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            blueTouched = true;
            //This for the sound effects 
            FindObjectOfType<AudioManager>().Play("Impact Sound");           //play Hurt Sound
            
            FindObjectOfType<AudioManager>().Play("Scream Sound");           //play scream sound
            Instantiate(deathFX, transform.position, Quaternion.identity);  //spill blood particles
            StartCoroutine("Delay");//delay laughter: Hurt - scream then laugh

        }
        //Are we missing the ability for this player to Check();
        //Has access to mannge level control (next scene)
    }


    //Sound Delay
    IEnumerator Delay()
    {
        // wait 5sec the play laughter
        yield return new WaitForSeconds(2f);        //delay 2seconds || 
        FindObjectOfType<AudioManager>().Play("Lose Sound");           //play laughing sound/lose
      
    }
}