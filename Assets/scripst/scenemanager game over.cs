using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagergameover : MonoBehaviour
{
    //descarga todas las escenas que no esten activas
    void Start()
    {
        Cursor.visible = true;
SceneManager.UnloadSceneAsync("SampleScene", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);

 
    }

    
  
}
