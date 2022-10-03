using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public Canvas PauseCanvas;
    
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Pressed");

            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseCanvas.enabled = false;
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void Pause()
    {
        PauseCanvas.enabled = true;
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(4);
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            SceneManager.LoadScene(1);
        }
    }
}
