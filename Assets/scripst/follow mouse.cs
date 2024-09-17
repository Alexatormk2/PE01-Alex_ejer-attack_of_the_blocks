using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class followmouse : MonoBehaviour
{//variables que guarda la posicion del raton y velocidad


   public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;

    Vector2 currentVelocity;

    void Update()

    {
        //funcion que detecta la posicion del raton u mueve el sprite en base a la velocidad de las variavles
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed); 
    }  
    }

