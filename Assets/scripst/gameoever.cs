using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gameoever : MonoBehaviour
{
    // Start is called before the first frame updat
    public int vidas = 3;
public float timer = 60;
public float timerEnd = 10;
public Collider2D  esfera;

public Collider2D  camion;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
         void OnTriggerEnter2D(Collider2D collision){if(collision.Equals(camion)&& vidas>0){vidas--;}
         if(collision.Equals(camion)&& vidas<=0) { 
               for(float a = 0f;a<= timerEnd; a++){
                Debug.Log("se cierra el juego en  "+ a +"  seg");  
                if(a==timerEnd){    Application.Quit();
    }
    }
    



}

    }
}
}