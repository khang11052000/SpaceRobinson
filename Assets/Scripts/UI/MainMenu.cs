using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
        {
            Debug.Log("Quit Game");
            Application.Quit();
            
        }
    
        public void LevelGame()
        {
            SceneManager.LoadScene("Level1");
        }
}
