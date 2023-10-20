using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool paused = false;
    // Update is called once per frame
    void Update()
    {
        if(!paused && Input.GetButtonDown("Pause")){
            Pause();
        }
        else if(paused && Input.GetButtonDown("Pause")){
            Unpause();
        }
    }

    public void Pause(){
        Time.timeScale = 0;
        paused = true;
        SceneManager.LoadScene("PauseScene", LoadSceneMode.Additive);
    }
    public void Unpause(){
        Time.timeScale = 1;
        PauseManager pauseManager = FindObjectOfType<PauseManager>();
        pauseManager.paused = false;
        if(SceneManager.GetSceneByName("PauseScene").isLoaded){
            SceneManager.UnloadSceneAsync("PauseScene");
        }
    }
    public void Quit(){
        Unpause();
        SceneManager.LoadScene("HomeScene");
    }
}
