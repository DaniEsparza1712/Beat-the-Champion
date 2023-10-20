using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionScript : MonoBehaviour
{
    public AudioSource audio;

    public void StartHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //de instuciones a home
    }
}
