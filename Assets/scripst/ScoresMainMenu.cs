using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresMainMenu : MonoBehaviour
{
    public Text score1text,score2text,score3text,score4text,score5text;
    public int [] score = new int[4];
    void Awake()
    {
     for(int contador =0;contador<score.Length;contador++)
     {
        score[contador] = PlayerPrefs.GetInt("score",0);
     }
        
     
     
        Debug.Log(score[0]);
        score1text.text = score[0].ToString();
        score2text.text = score[1].ToString();
        score3text.text = score[2].ToString();
        score4text.text = score[3].ToString();
        score5text.text = score[4].ToString();
    }

   
}
