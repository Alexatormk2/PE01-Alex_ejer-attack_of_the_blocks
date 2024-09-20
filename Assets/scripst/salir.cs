using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salir : MonoBehaviour
{

    void Start()
    {//hace que el cursor se oculte
        Cursor.visible = false;
        
    }

  
    void Update()
    {
        //cuando se pulsa la tecla esc cierra el juego
        if(Input.GetKeyDown(KeyCode.Escape)){

            Application.Quit();
        }
    }
}
