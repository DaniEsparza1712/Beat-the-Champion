using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int winPoints;
    public ScoreHolder scoreHolder;
    public PlayerMachine playerMachine;
    // Update is called once per frame
    void Update()
    {
        if(playerMachine.gameLost){
            SceneManager.LoadScene("LooserScene");
        }
        if(scoreHolder.GetScore >= winPoints){
            SceneManager.LoadScene("WinnerScene");
        }
    }
}
