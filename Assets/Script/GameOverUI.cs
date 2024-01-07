using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
   private void Awake()
   {
      // setzt die Zeit wieder auf 1 so das das Spiel weiterlaufen kann 
      Time.timeScale = 1;
   }

   public void StartNewGame()
   {
      // lädt die Sezene 1 also das level 
      SceneManager.LoadScene(1);
      
   }
}
