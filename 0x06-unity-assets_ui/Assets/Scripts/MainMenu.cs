using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button Level01;
    public Button Level02;
    public Button Level03;
    public Button OptionsButton;
    public Button Exit;

    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Options()
    {
        PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
    
    public void ExitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}