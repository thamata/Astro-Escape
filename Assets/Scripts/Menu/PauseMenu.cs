using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static bool isPaused = false;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        isPaused = false;
    }

    public void Restart(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        isPaused = false;
    }
}
