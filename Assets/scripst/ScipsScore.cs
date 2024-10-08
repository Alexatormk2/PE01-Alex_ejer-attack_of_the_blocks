using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ScipsScore : MonoBehaviour
{
    // Start is called before the first frame update
   
    

   public static void SaveScores(int newScore)
   {
    int[] scorelist = new int[4];
    scorelist = LoadScores();
    //falta comrpara lista ocn el score nuevo    

   }
   public static int[] LoadScores()
   {
    int[] scorelist = new int[4];

    

    return scorelist;

   }
}
