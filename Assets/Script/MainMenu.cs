using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // eine Methode in der die Szene 1 geladen wird,also das Spiel 
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
  // prüft ob grade gespeielt wird und schliest gegeben Falls dqas fenster 
    public void ExitGame()
    {
     #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
      #endif
    }
  
}
