using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gameoever : MonoBehaviour
{

    //vidas del jugador son los hits que puede comer y timer para el cierre del juego
    public int vidas = 3;
public float timer = 20;

  

//metodo que revisa las colisiones las vidas restantes dle jugador y si son igual a 0 cierra el juego 
void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "bola" && vidas >0){
         Debug.Log("hit");
        vidas--;
    }
    else if(collision.gameObject.tag == "bola" && vidas <=0){
          Debug.Log("game over");
        Destroy(gameObject);
        //for que hace que se cierre el juego tras acabar la partida
        for(int contador =0; contador<timer;contador++){

Debug.Log("se cierra en  " + contador);
        }
       
         
         
    
         Application.Quit();
       
    }
}

    
    
    



}

