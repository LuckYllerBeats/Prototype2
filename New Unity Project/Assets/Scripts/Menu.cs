using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("BG Sound"); //plau menu sound
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Tutorial");

    }

    public void ExitGame()
    {
        Application.Quit();

    }

}
