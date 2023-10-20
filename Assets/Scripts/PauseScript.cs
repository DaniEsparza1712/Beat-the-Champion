using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public void PauseStartContinue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4); //de pausa a juego
    }
    public void PauseStartHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6); //de pausa a home
    }
}