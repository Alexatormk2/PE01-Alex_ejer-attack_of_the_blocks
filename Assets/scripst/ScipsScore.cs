using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public  class ScipsScore : MonoBehaviour
{
    // Start is called before the first frame update
   
    

   public static void SaveScores(int newScore)
   {
    
    
    //falta comrpara lista ocn el score nuevo    

   }
   public static int[] LoadScores()
   {
    int[] scorelist = new int[5];
    PlayerPrefs.GetInt("score1",scorelist[0]);
    PlayerPrefs.GetInt("score2",scorelist[1]);
    PlayerPrefs.GetInt("score3",scorelist[2]);
    PlayerPrefs.GetInt("score4",scorelist[3]);
    PlayerPrefs.GetInt("score5",scorelist[4]);
    return scorelist;

   }
}
