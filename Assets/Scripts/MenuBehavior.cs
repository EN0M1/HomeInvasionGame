using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MenuBehavior : MonoBehaviour
{
    public void GoToGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }

    /*
    public void GoToMenu()
    {
        Debug.Log("menu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void GoToSettings()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToDiffSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("DifficultySelect");
    }

    public void GoToTutorial()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HowToPlay");
    }

    public void GoToCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CreditsScene");
    }
    */

    public void ExitGame()
    {
        Application.Quit();
    }
}
