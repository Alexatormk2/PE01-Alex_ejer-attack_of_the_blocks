using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresMainMenu : MonoBehaviour
{
    public Text score1text,score2text,score3text,score4text,score5text;
    public int [] score = new int[4];
    GameOver gameOver = new GameOver();
    void Awake()
    {
      score= GameOver.LoadScores();
        //leemos los datos de la lista para pasarlos
        score[0] = PlayerPrefs.GetInt("score",0);
        score[1] = PlayerPrefs.GetInt("score2",0);
        score[2] = PlayerPrefs.GetInt("score3",0);
        score[3] = PlayerPrefs.GetInt("score4",0);
        score[4] = PlayerPrefs.GetInt("score5",0);
        //cargamos los datos obtenidos del archivo
        score1text.text = score[0].ToString();
        score2text.text = score[1].ToString();
        score3text.text = score[2].ToString();
        score4text.text = score[3].ToString();
        score5text.text = score[4].ToString();
    }

   
}
