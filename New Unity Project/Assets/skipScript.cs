using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipScript : MonoBehaviour {

    public KeyCode left;

    void Update()
    {
        if (Input.GetKey(left))

        {

            SceneManager.LoadScene("Main");
        }
    }
}
