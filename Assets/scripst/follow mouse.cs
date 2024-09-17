using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followmouse : MonoBehaviour
{//variables que guarda la posicion del raton y velocidad
    private Vector3 mousePosition;
	public float moveSpeed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //funcion que detecta al moouse moverse mientras se precsiona un click
     if (Input.GetMouseButton(0)) {
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
		}

	}   
    }

