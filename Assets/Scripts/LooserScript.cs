using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooserScript : MonoBehaviour
{
    public AudioSource audio;

    public void lostStartHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5); //de ganar a home
    }
    public void lostQuit()
    {
        audio.Play();
        print("quit");
        Application.Quit();
    }
}