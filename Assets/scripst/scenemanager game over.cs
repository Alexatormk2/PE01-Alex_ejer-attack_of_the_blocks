using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagergameover : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    //descarga todas las escenas que no esten activas
    void Start()
    {
        audioSource.PlayOneShot(audioClip);
        Cursor.visible = true;
    

 
    }

    
  
}
