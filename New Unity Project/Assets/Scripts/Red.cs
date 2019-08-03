using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Red : MonoBehaviour
{

	public static Red instance;
    public bool redTouched;
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
        if (goBack && redTouched)
        {
            redTouched = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
      
            redTouched = true;
            //This for the sound effects 
            FindObjectOfType<AudioManager>().Play("Impact Sound");           //play Hurt Sound

            FindObjectOfType<AudioManager>().Play("Scream Sound");           //play scream sound
            Instantiate(deathFX, transform.position, Quaternion.identity);  //spill blood particles
            StartCoroutine("Delay");//delay laughter: Hurt - scream then laugh

        }
        if (col.gameObject.tag == "Check") //Has access to mannge level control (next scene)
        {
            //Debug.Log("touch");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    //Sound Delay
    IEnumerator Delay()
    {
        // wait 5sec the play laughter
        yield return new WaitForSeconds(2f);//delay Xseconds
        FindObjectOfType<AudioManager>().Play("Lose Sound");           //play laughing sound/lose

    }
}