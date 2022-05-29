using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame_Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseMenuBackground;
    public void PauseGame()
    {
        Time.timeScale = 0;

        pauseMenu.SetActive(true);
        pauseMenuBackground.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;

        pauseMenu.SetActive(false);
        pauseMenuBackground.SetActive(false);
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
