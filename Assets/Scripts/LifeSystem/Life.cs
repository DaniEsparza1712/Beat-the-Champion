using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public List<LifePoint> lifePoints;
    public PlayerMachine playerMachine;
    public AudioClip deathSound;
    public AudioSource audioSource;
    private void Start() {
        for(int i = 0; i < lifePoints.Count; i++){
            lifePoints[i].SetLife(true);
        }
    }
    public void GetHit(){
        for(int i = 0; i < lifePoints.Count; i++){
            if(lifePoints[i].activeLife){
                lifePoints[i].SetLife(false);
                break;
            }
        }
        if(!IsAlive()){
            audioSource.PlayOneShot(deathSound);
            playerMachine.SetChangeTo("Death");
        };
    }
    private bool IsAlive(){
        foreach(LifePoint lPoint in lifePoints){
            if(lPoint.activeLife){
                return true;
            }
        }
        return false;
    }
}
