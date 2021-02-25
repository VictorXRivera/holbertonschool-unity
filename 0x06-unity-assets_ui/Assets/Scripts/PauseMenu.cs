using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused;
    public Canvas PauseCanvas;
    public Stopwatch timer = new Stopwatch();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        PauseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        timer.Stop();
    }

    public void Resume()
    {
        PauseCanvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        timer.Start();
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            SceneManager.LoadScene(1);
        }
    }
}