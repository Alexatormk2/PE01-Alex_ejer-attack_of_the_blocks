using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoever : MonoBehaviour
{


    //vidas del jugador son los hits que puede comer y timer para el cierre del juego
    public int vidas = 3;
public float timer = 20;

  scenemanager escnee;

//metodo que revisa las colisiones las vidas restantes dle jugador y si son igual a 0 cierra el juego 
void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "bola"){
             Debug.Log("game over");

  
   SceneManager.LoadSceneAsync( "game over", LoadSceneMode.Single);
        }       
    }
   
}

    
    
    





