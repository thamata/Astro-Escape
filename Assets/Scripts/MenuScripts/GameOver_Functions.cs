using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_Functions : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
