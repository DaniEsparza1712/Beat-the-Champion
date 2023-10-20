using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    private int score;
    public int GetScore => score;
    public TMP_Text scoreText;
    public ParticleSystem collideParticles;
    public AudioSource audioSource;
    public AudioClip audioClip;
    private void Update() {
        scoreText.text = score.ToString();
        if(score < 0){
            score = 0;
        }
    }
    public void AddToScore(int points){
        score += points;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Points") && transform.gameObject.GetComponent<CapsuleCollider>().enabled){
            PointObject pointObj = other.GetComponent<PointObject>();

            Instantiate(pointObj.hitParticle, other.transform.position, Quaternion.identity);
            Instantiate(collideParticles, other.transform.position, Quaternion.identity);

            audioSource.PlayOneShot(audioClip);

            AddToScore(pointObj.GetPoints);
            pointObj.gameObject.SetActive(false);
        }
    }
}
