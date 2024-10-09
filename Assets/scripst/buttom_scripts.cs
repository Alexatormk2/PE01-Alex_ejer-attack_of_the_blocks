using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttom_scripts : MonoBehaviour

  {
    //scrip que controla que hacen los botones de los menus, algunos comparten metodo
public void Salirse()
{//solo funciona en la build, sirve para cerrar el juego
     Application.Quit();
}
public void Begingame()
{//boton del menu principal que inicia la partida

     SceneManager.LoadSceneAsync( "gamescreen", LoadSceneMode.Single);
     SceneManager.UnloadSceneAsync("mainmenu", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
}
public void MainMenu()
{//regresa al menu pruncipal
     SceneManager.LoadSceneAsync( "mainmenu", LoadSceneMode.Single);
     SceneManager.UnloadSceneAsync("gameover", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
     
     
}
public void Retry()
{
    SceneManager.LoadSceneAsync( "gamescreen", LoadSceneMode.Single);
    SceneManager.UnloadSceneAsync("gameover", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
}
public void pauseGame()
{
     //metodo que abre el menu de pause y pausa el juego
SceneManager.LoadSceneAsync("pausescreen",LoadSceneMode.Additive);
Time.timeScale =0;
}
public void ResumeGame()
{//cierra el menu de pause y reanuda el juego
     SceneManager.UnloadSceneAsync("pausescreen");
     
     Time.timeScale = 1;
     
}
public void Update()
{
      if(Input.GetKeyDown(KeyCode.Escape)){
        pauseGame();
        
        
          
        }
}
  
}
