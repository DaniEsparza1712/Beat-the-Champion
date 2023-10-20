using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour
{
    public AudioSource audio;

    public void WinStartHome()
    {
        audio.Play();
        print("quit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4); //de ganar a home
    }
    public void WinQuit()
    {
        audio.Play();
        print("quit");
        Application.Quit();
    }
}
