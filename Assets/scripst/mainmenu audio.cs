using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuaudio : MonoBehaviour
{   public AudioSource audioSource;
    public AudioClip[] audioClip;
    // Start is called before the first frame update
    void Start()
    {
            audioSource.clip = audioClip[0];
            audioSource.Play();

    }

}
