using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public void StartWiner()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); //de juego a ganar
    }
    public void StartLooser()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); //de juego a perder
    }
    public void StartPause()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); //de juego a pausa
    }
}
