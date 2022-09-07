using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    int inc = 0;
    public Text incText;
    
    public void ScoreUp()
    {
        score += 1;
        scoreText.text = score + "";
    }

    public void ShopUp()
    {
        if(score >= 3)
        {
            score -= 3;
            inc += 1;
            scoreText.text = score + "";
            incText.text = "inc = " + inc;
        }
    }
}
