using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public static UpdateScore instance;
    Text ScoreText;
    private void Start()
    {
        ScoreText = GetComponent<Text>();
        instance = this;
    }
    private void Update()
    {
        AddingScore();

    }
    void AddingScore()
    {
        ScoreText.text = ScoreSystem.scoretotal.ToString();
    }
}
