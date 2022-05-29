using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int shipsAlive = 3;

    public static float astroidSpeed = 4f;
    public static float enemySpeed = 2f;

    private double increaseScore = 500;
    private double score;
    private int finalScore;

    public ScoreCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = counter.score;
        finalScore = Mathf.RoundToInt((float)score);
        if (increaseScore < score)
        {
            astroidSpeed += .3f;
            enemySpeed += .15f;
            increaseScore += 500;
        }
        if(shipsAlive == 0)
        {
            if(finalScore > PlayerPrefs.GetInt("HighScore",0)){
                PlayerPrefs.SetInt("HighScore", finalScore);
            }
            
            SceneManager.LoadScene(2);
            shipsAlive = 3;
            astroidSpeed = 4f;
            enemySpeed = 2f;
        }
    }
}
