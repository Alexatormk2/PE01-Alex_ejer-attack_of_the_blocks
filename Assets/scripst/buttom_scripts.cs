using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttom_scripts : MonoBehaviour

  {//boton salir dle juego
public void Salirse(){
     Application.Quit();
}
public void Begingame(){
     SceneManager.LoadSceneAsync( "gamescreen", LoadSceneMode.Additive);
SceneManager.UnloadSceneAsync("mainmenu", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
}
public void Retry(){
  SceneManager.LoadSceneAsync( "gamescreen", LoadSceneMode.Single);
SceneManager.UnloadSceneAsync("game over", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
}
  
}
