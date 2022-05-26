using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu_ExitGame : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject confirmPanel;

    public void ConfirmExitGame()
    {
        menuPanel.SetActive(false);
        confirmPanel.SetActive(true);
    }
    public void CancelExitGame()
    {
        menuPanel.SetActive(true);
        confirmPanel.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
