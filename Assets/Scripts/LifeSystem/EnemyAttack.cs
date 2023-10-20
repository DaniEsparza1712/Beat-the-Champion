using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public ParticleSystem hitParticles;
    public ParticleSystem letterParticles;
    //Will use player audioSource
    [HideInInspector] public AudioSource audioSource;
    public AudioClip audioClip;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player") && !other.isTrigger){

            //Gets player audio source and plays the customized hit sound
            audioSource = other.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioClip);

            Instantiate(hitParticles, transform.position, Quaternion.identity);
            Instantiate(letterParticles, transform.position, Quaternion.identity);
            other.GetComponent<Life>().GetHit();
            other.GetComponent<ScoreHolder>().AddToScore(-1);
        }
    }
}
