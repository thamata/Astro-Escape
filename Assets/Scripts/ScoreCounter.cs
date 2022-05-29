using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text counterText;
    public Sprite[] multiplierImages;
    public Image multiplierImage;
    public double score;
    public double multiplier;
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
        if (GameController.shipsAlive != 0) { 
            if (GameController.shipsAlive == 3)
            {
                multiplier = 1;
                multiplierImage.sprite = multiplierImages[0];
            
            }
            else if(GameController.shipsAlive == 2)
            {
                multiplier = .8;
                multiplierImage.sprite = multiplierImages[1];

            }
            else if (GameController.shipsAlive == 1)
            {
                multiplier = .6;
                multiplierImage.sprite = multiplierImages[2];

            }
            score += multiplier * (int)Time.timeScale;
            Debug.Log(multiplier);
        }
        

        
    }
}
