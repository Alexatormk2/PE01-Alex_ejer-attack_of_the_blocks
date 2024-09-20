using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerbola : MonoBehaviour
{
   
   
//variables para definir que objeto hace spawn, su posicoin y sus contadores
 public GameObject boom;
 float x = 1;
 float y = 2;
 public int numbola= 3;
  public int contador;
public void spawn(){
       
//for que se ejecuta al inicio de la partida para hacer spaw de las bolas
 for( contador = 0;contador<=numbola;contador++){
            Instantiate(boom, new Vector2(x, y), Quaternion.identity);

            
                y = y + 0.5f;
                x = x + 1;
            
              }
     
             
             

}
                
    //el metodo start lo invoca
    void Start()
    {
        spawn();
    }
}
