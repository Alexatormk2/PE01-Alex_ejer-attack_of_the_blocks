using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnerbola : MonoBehaviour
{
   

//variables para definir que objeto hace spawn, su posicoin y sus contadores
 public GameObject heal;
  public GameObject spikeBall;
 public GameObject spikeshield;

 float x = 1;
 float y = 2;
public void SpawnHeal(){     
  //for que que tira unos dados para decidir donde aparece el item  

  
      y = Random.Range(0, 2);
      x = Random.Range(1,4);
      Instantiate(heal, new Vector2(x, y), Quaternion.identity);           
             
    
}

public void SpawnSpikeShield(){     
  //for que que tira unos dados para decidir donde aparece el item 

      y = Random.Range(0, 2);
      x = Random.Range(1,4);
      Instantiate(spikeshield, new Vector2(x, y), Quaternion.identity);          
        
            
    
}

public void SpawBalls()
{
for(int contador = 0;contador <=3;contador++)
{
      y = Random.Range(0, 2);
      x = Random.Range(1,4);
      Instantiate(spikeBall, new Vector2(x, y), Quaternion.identity);
}
  
}
                
    //el metodo start lo invoca
    void Start	()
    {

    
   
    InvokeRepeating(nameof(SpawBalls),8,120);
    InvokeRepeating(nameof(SpawnHeal),10,10);
    InvokeRepeating(nameof(SpawnSpikeShield),1,60);
         

       
    }
}
