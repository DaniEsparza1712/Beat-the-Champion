using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour
{
    public AudioSource audioButton;
    public AudioClip audioClip;

    /*public IEnumerator WaitForAudio()
    {
        yield return new WaitForSeconds(3.0f);
    }*/
    /*public async void WaitForAudio()
    {
        await Task.Yield();
    }*/

    public void StartHome()
    {
        audioButton.PlayOneShot(audioClip);
        //StartCoroutine("WaitForAudio");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); //de storyome
    }
}
