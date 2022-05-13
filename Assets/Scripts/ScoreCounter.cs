using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text counterText;
    public Text multiplierText;
    public double score;
    public double mulitplier;
    public int intScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intScore = Mathf.RoundToInt((float)score);
        counterText.text = intScore.ToString();
        multiplierText.text = "x" + mulitplier.ToString();
        if (GameController.shipsAlive == 3)
        {
            mulitplier = 1;
            
        }
        else if(GameController.shipsAlive == 2)
        {
            mulitplier = .8;
            
        }
        else if (GameController.shipsAlive == 1)
        {
            mulitplier = .6;
            
        }

        score += mulitplier;

        
    }
}
