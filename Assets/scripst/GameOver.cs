using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{


    //vidas del jugador son los hits que puede comer y timer para el cierre del juego
    public int hearts = 3;
    public Text heartext;
    public Text timertext;
    public Text timeInvu;

    public Collider2D rigidtruck;
    public AudioSource audioSource;
    public AudioClip audioSPikeBuster;
    public AudioClip audioClip;
    public AudioClip audioHeal;
    public AudioClip audioInvuOn;
    public AudioClip audioHit;
    public AudioClip audioInvuOff;
    public GameObject repairkit;
    public int score =0;
    public float invulnerabilitySec =15f;
    public float roundtime =60f;
    bool invuOn = false;
    bool shieldOn = false; 


 

  void Start()
  {
    //carga el valor inicial de las vidas en el cuadro de hp
        heartext.text = hearts.ToString();

        //PlayerPrefs.Save
  }


 void  Update()
  {
    //meotod que sirve para poner un tiempo limite la jugador
  TimerRonda();
  Invoke(nameof( winScreen),roundtime);
  if(invuOn == true)
  {
    TimerInvu();
  }

  }

  void winScreen()
  {
   score = 60;         
             SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
             SceneManager.LoadSceneAsync( "youwin", LoadSceneMode.Single);
  }
  //esta funcion se encragar de desactivar la invulnerabilidad cuando su cuenta se acaba
  void InvulnerabilityEnd()
  {
    rigidtruck.enabled =true;
    audioSource.PlayOneShot(audioInvuOff);
    timeInvu.text = "0";
    invulnerabilitySec = 20;
    invuOn = false;
  }

  void TimerRonda(){
    timertext.text = roundtime.ToString();
      roundtime -=Time.deltaTime;
  }
  void TimerInvu(){

    timeInvu.text = invulnerabilitySec.ToString();
    invulnerabilitySec -=Time.deltaTime;
  
  }


  
    void OnCollisionEnter2D(Collision2D collision)
    {
        //power up que cura  o aumenta la vida maixma al jugador
        if(collision.gameObject.tag == "heal")
        {
          hearts ++;
          heartext.text = hearts.ToString();
          Destroy(collision.gameObject);
          audioSource.PlayOneShot(audioHeal);
    
        }
        if(collision.gameObject.tag == "spikebuster")
        {
          audioSource.PlayOneShot(audioSPikeBuster);
          shieldOn = true;
          Destroy(collision.gameObject);
          

        }
        
      
        //si el power up de spike buster esta activo destruye la bola con la que choque
        if(collision.gameObject.tag == "bola" && shieldOn ==true)        
        {
          Destroy(collision.gameObject);
          audioSource.PlayOneShot(audioHit);
         shieldOn = false;
        }
        else if( collision.gameObject.tag == "bola" && hearts >0)
        {
                
                audioSource.PlayOneShot(audioClip);
            //all recibir daño resta una vida de la variable y muestra en consola las vidas restantes y reproduce dos audios uno al recibir daño y otro al activar la invulnerabilidad
                hearts--;
                heartext.text = hearts.ToString();
                Debug.Log("remaining hearts " + hearts);
              
                rigidtruck.enabled =false;
                audioSource.PlayOneShot(audioInvuOn);
                invuOn = true;
                Invoke(nameof(InvulnerabilityEnd), invulnerabilitySec);
         
        }
        else if (hearts <=0)
        {
                Debug.Log("game over");
           
    
                SceneManager.LoadSceneAsync( "game over", LoadSceneMode.Single);
                SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        } 
        
        
    }
   
}

    
    
    





