using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{


    //vidas del jugador son los hits que puede comer y timer para el cierre del juego
    public int hearts = 3;

    public Rigidbody2D rigidtruck;
    bool nodamage = false;
    public float invulnerabilityframes = 20f;

 
//metodo que revisa las colisiones y las vidas restantes dle jugador y si son igual a 0 muestra el menu de game over 
    void OnCollisionEnter2D(Collision2D collision)
    {
        invulnerabilityframes = 20f;
        if( collision.gameObject.tag == "bola" && hearts >=1)
        {
                
            //all recibir daño resta una vida de la variable y muestra en consola las vidas restantes, aparte permiete entrar al if para activar la invencibildiad
                hearts--;
                Debug.Log("remaining hearts " + hearts);
                nodamage = true;
                    if(nodamage = true && hearts>0&& invulnerabilityframes >0)
                    {   
                        rigidtruck.Sleep();
                        invulnerabilityframes =-Time.deltaTime;
                            Debug.Log("you cant take damege on " +invulnerabilityframes );
                        rigidtruck.Sleep();
                    }
                    else
                    {
                        invulnerabilityframes = 0;
                        rigidtruck.WakeUp();
                        Debug.Log("invu run out");
                        nodamage = false;
                    
                    }



        }
        else if ( collision.gameObject.tag == "bola" && hearts <=0)
        {
                Debug.Log("game over");

    
                SceneManager.LoadSceneAsync( "game over", LoadSceneMode.Single);
        } 
        
        
    }
   
}

    
    
    





