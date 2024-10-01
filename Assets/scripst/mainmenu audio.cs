 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuaudio : MonoBehaviour
{   public AudioSource audioSource;
    public AudioClip[] audioClip;
    // musica de ambiente usada en todos los menus(falta la de game over y win) 
    void Start()
    {
            audioSource.clip = audioClip[0];
            audioSource.Play();

    }

}
