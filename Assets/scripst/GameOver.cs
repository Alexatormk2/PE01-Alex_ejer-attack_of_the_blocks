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
    bool nodamage = false;
    public float invulnerabilityframes = 1f;
    public float roundtime = 1f;

 
//metodo que revisa las colisiones y las vidas restantes dle jugador y si son igual a 0 muestra el menu de game over 
  
  void Start()
  {
    
        heartext.text = hearts.ToString();

     

  }
  void Update()
  {
   if(roundtime>0)
        {
        roundtime -=Time.deltaTime;

        
        float seconds = Mathf.FloorToInt(roundtime % 60);

      //  timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
      timertext.text = seconds.ToString();
      timermin.text ="0";
        }
        else
        {
        roundtime=0;
        }
    if(roundtime==0 && hearts>=1)
        {

             SceneManager.LoadSceneAsync( "youwin", LoadSceneMode.Single);
             SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        }

  }
  
    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if(collision.gameObject.tag == "heal")
        {
        hearts ++;
        heartext.text = hearts.ToString();
        }
        
        else if( collision.gameObject.tag == "bola" && hearts >=1)
        {
                
                audioSource.PlayOneShot(audioClip);
            //all recibir daño resta una vida de la variable y muestra en consola las vidas restantes, aparte permiete entrar al if para activar la invencibildiad
                hearts--;
                heartext.text = hearts.ToString();
                Debug.Log("remaining hearts " + hearts);
                nodamage = true;
                    if(nodamage == true && hearts>=1 && invulnerabilityframes >0)
                    {   for(float contador = 0f;contador <= invulnerabilityframes;contador++){
                        rigidtruck.enabled =false;
                        invulnerabilityframes -=Time.deltaTime;
                            Debug.Log("you cant take damege on " +invulnerabilityframes );
                    }
                    }
                    else
                    {
                        invulnerabilityframes = 30f;
                        rigidtruck.enabled =true;
                        Debug.Log("invu run out");
                        nodamage = false;
                    
                    }



        }
        else if ( collision.gameObject.tag == "bola" && hearts <=0)
        {
                Debug.Log("game over");
           
    
                SceneManager.LoadSceneAsync( "game over", LoadSceneMode.Single);
                SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        } 
        
        
    }
   
}

    
    
    





