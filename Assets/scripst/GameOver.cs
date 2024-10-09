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
    int hearts = 3;
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
    float invulnerabilitySec =10f;
    public float roundtime =30;
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
    score = score * hearts;
      SaveScores(score);
      SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
      SceneManager.LoadSceneAsync( "youwin", LoadSceneMode.Single);
  }
  //esta funcion se encragar de desactivar la invulnerabilidad cuando su cuenta se acaba
  void InvulnerabilityEnd()
  {
    rigidtruck.enabled =true;
    audioSource.PlayOneShot(audioInvuOff);
    timeInvu.text = "0";
    invulnerabilitySec = 10f;
    invuOn = false;
  }

  void TimerRonda(){
    timertext.text = roundtime.ToString();
      roundtime -=Time.deltaTime;
       score++;


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
         
        else if( collision.gameObject.tag == "bola" && hearts >=1)
        {
               
                audioSource.PlayOneShot(audioClip);
            //all recibir daño resta una vida de la variable y muestra en consola las vidas restantes y reproduce dos audios uno al recibir daño y otro al activar la invulnerabilidad
                hearts--;

                heartext.text = hearts.ToString();
                Debug.Log("remaining hearts " + hearts);
               if (hearts <=0)
                  {
                    score = score - 50;
                    Debug.Log("game over");
                    
        
                    SceneManager.LoadSceneAsync( "gameover", LoadSceneMode.Single);
                    SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
                    SaveScores(score);
                  }
              
                rigidtruck.enabled =false;
                audioSource.PlayOneShot(audioInvuOn);
                invuOn = true;
                Invoke(nameof(InvulnerabilityEnd), invulnerabilitySec);
         
        }else if (hearts <=0)
                  {
                    score = score - 50;
                    Debug.Log("game over");
                    
        
                    SceneManager.LoadSceneAsync( "gameover", LoadSceneMode.Single);
                    SceneManager.UnloadSceneAsync("gamescreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
                    SaveScores(score);
                  }   }

  public static void SaveScores(int score){
    int[] scorelist = new int[5];
                    scorelist = LoadScores();
                    if(scorelist[0]<score)
                    {
                        scorelist[0] = score;
                    }
                    else if(scorelist[1]<score)
                    {
                        scorelist[1] = score;    
                    }
                    else if(scorelist[2]<score)
                    {
                        scorelist[2] = score;    
                    }
                    else if(scorelist[3]<score)
                    {
                        scorelist[3] = score;    
                    }
                    else if(scorelist[4]<score)
                    {
                        scorelist[4] = score;    
                    }
                    PlayerPrefs.SetInt("score",scorelist[0]);
                    PlayerPrefs.SetInt("score2",scorelist[1]);
                    PlayerPrefs.SetInt("score3",scorelist[2]);
                    PlayerPrefs.SetInt("score4",scorelist[3]);
                    PlayerPrefs.SetInt("score5",scorelist[4]);
                    PlayerPrefs.Save();
  }                                
  public static int[] LoadScores()
   {

    int[] scorelist = new int[5];
   scorelist[0] = PlayerPrefs.GetInt("score",0);
    scorelist[1] =PlayerPrefs.GetInt("score2",0);
   scorelist[2] = PlayerPrefs.GetInt("score3",0);
  scorelist[3] = PlayerPrefs.GetInt("score4",scorelist[3]);
   scorelist[4] = PlayerPrefs.GetInt("score5",scorelist[4]);
    return scorelist;

   }
        
        
    
   
}

    
    
    





