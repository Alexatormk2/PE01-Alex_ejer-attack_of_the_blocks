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
    public Text timermin;
    public Collider2D rigidtruck;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip audioInvuOn;
    public AudioClip audioInvuOff;
    public GameObject repairkit;
    
    public float invulnerabilitySec =20f;
    public float roundtime =120f;

 

  void Start()
  {
    //carga el valor inicial de las vidas en el cuadro de hp
        heartext.text = hearts.ToString();
  }


 void  Update()
  {
    //meotod que sirve para poner un tiempo limite la jugador
  Invoke(nameof( winScreen),10);
  }

  void winScreen()
  {
             
             SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
             SceneManager.LoadSceneAsync( "youwin", LoadSceneMode.Single);
  }
  //esta funcion se encragar de desactivar la invulnerabilidad cuando su cuenta se acaba
  void InvulnerabilityEnd()
  {
    rigidtruck.enabled =true;
    audioSource.PlayOneShot(audioInvuOff);
  }

  
    void OnCollisionEnter2D(Collision2D collision)
    {
        //power up que cura  o aumenta la vida maixma al jugador
        if(collision.gameObject.tag == "heal")
        {
          hearts ++;
          heartext.text = hearts.ToString();
          Destroy(collision.gameObject);
    
        }
      //al recibir daño desactiva por x tiempo el collider para sobrevivir un poco
        
        
        else if( collision.gameObject.tag == "bola" && hearts >0)
        {
                
                audioSource.PlayOneShot(audioClip);
            //all recibir daño resta una vida de la variable y muestra en consola las vidas restantes y reproduce dos audios uno al recibir daño y otro al activar la invulnerabilidad
                hearts--;
                heartext.text = hearts.ToString();
                Debug.Log("remaining hearts " + hearts);
              
                rigidtruck.enabled =false;
                audioSource.PlayOneShot(audioInvuOn);

                Invoke(nameof(InvulnerabilityEnd), invulnerabilitySec);
                
                     
                        invulnerabilitySec -=Time.deltaTime;
                        
                        invulnerabilitySec = 15f;
                       
                       
                   



        }
        else if (hearts <=0)
        {
                Debug.Log("game over");
           
    
                SceneManager.LoadSceneAsync( "game over", LoadSceneMode.Single);
                SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        } 
        
        
    }
   
}

    
    
    





