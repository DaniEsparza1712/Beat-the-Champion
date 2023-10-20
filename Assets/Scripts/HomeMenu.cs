using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    public void StartInstructions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //de home a instrucciones
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); //de home a juego
    }
    public void StartStory()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); //de home a historia
    }
}