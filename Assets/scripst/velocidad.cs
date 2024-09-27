using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using JetBrains.Annotations;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class velocidad : MonoBehaviour
{
//variable para el rigibody del objetivo esfera
    public AudioSource audioSource;
    public AudioClip audioClip;
  
    public Rigidbody2D esfera;
 
void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.tag == "limite")
        {

                audioSource.PlayOneShot(audioClip);


        }
    }
  
    void Start()
    {
    //añade una fuerza relativa que impulsa la esfera en una direccion

   
           esfera.AddRelativeForce( transform.position * 1f);
       
    }
   
   
        
   
        
    

   
}
