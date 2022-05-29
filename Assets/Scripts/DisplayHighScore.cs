using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = "High Score: \n" + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
