using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public bool isPaused;
    public Text counterText;
    public double score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isPaused = PauseMenu.isPaused;
        counterText.text = score.ToString();
        if (!isPaused)
        {
            if (GameController.shipsAlive == 3)
            {
                score += 1;
            }
            else if (GameController.shipsAlive == 2)
            {
                score += .8;
            }
            else if (GameController.shipsAlive == 1)
            {
                score += .6;
            }
        }

        
    }
}
