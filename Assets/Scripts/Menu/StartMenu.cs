using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void ButtonPress(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
