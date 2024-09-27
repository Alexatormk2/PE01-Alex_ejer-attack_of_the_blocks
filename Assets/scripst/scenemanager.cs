using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    //descarga todas las escenas que no esten activas
    void escenacmabiar(){
          SceneManager.LoadSceneAsync( "game over", LoadSceneMode.Additive);
  }



    void Start()
    {
        SceneManager.UnloadSceneAsync("mainmenu", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
SceneManager.UnloadSceneAsync("game over", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);

 
    }

    
  
}
