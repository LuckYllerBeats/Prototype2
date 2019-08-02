using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("BG Sound");    //Play bounce sound
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            FindObjectOfType<AudioManager>().Play("BG Sound");    //BG Sound
        }

    }

   
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(.5f);
        
    }
}
