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

    public ScoreCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = counter.score;
        if (increaseScore < score)
        {
            astroidSpeed += .5f;
            enemySpeed += .25f;
            increaseScore += 500;
        }

        if (shipsAlive == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}