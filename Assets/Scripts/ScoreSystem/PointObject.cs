using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObject : MonoBehaviour
{
    public int points;
    public int GetPoints => points;
    public int speed;
    public ParticleSystem hitParticle;
    public AudioClip appearClip;
    public AudioSource audioSource;

    private void LateUpdate() {
        transform.Translate(Vector3.forward * Time.deltaTime *speed);
    }
    private void OnEnable() {
        audioSource.PlayOneShot(appearClip);
    }
}
