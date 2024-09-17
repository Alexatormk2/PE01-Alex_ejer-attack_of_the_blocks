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
  
    public Rigidbody2D esfera;
 

  
    void Start()
    {
    //añade una fuerza relativa que impulsa la esfera en una direccion

   
           esfera.AddRelativeForce( transform.position * 6);
       
    }
   
    void FixedUpdate()

    {
        
   
        
    } 

   
}
