using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttom_scripts : MonoBehaviour

  {
    //scrip que controla que hacen los botones de los menus, algunos comparten metodo
public void Salirse()
{
     Application.Quit();
}
public void Begingame()
{

     SceneManager.LoadSceneAsync( "gamescreen", LoadSceneMode.Single);
     SceneManager.UnloadSceneAsync("mainmenu", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
}
public void MainMenu()
{
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
SceneManager.LoadSceneAsync("pausescreen",LoadSceneMode.Additive);
Time.timeScale =0;
}
public void ResumeGame()
{
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
