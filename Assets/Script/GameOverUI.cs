using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
   private void Awake()
   {
      Time.timeScale = 1;
   }

   public void StartNewGame()
   {
      
      SceneManager.LoadScene(1);
      
   }
}
