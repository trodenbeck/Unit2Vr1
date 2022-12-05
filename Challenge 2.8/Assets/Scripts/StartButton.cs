using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerMovement.lives = 3;
    }
    public void QuitGame()
    {
        Debug.Log("Bye Bye :(");
        Application.Quit();
    }
    public void RestartLevel()
    {
        
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
