using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using JetBrains.Annotations;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class velocidad : MonoBehaviour
{
//variable para la suavidad con lo que se mueve la bola
  
    public Rigidbody2D esfera;
   private float y = 0f;
   private float x =    Random.Range(0f,4f);

  
    // Start is called before the first frame update
    void Start()
    {
        Vector2 v = new Vector2(x,y);
         esfera.AddForce(v);
       
       
    }

   
}
