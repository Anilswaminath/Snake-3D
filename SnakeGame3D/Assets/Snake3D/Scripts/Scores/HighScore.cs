using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int currentScore;
    public static int highScore;
    Text highScoretext;
    private void Awake()
    {
        highScoretext = GetComponent<Text>();
        currentScore = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoretext.text = highScore.ToString();
    }
    private void Update()
    {
        currentScore = ScoreSystem.scoretotal;
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoretext.text = highScore.ToString();
        }
    }
}
