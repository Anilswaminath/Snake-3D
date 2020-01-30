using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScoreSystem : MonoBehaviour
{
    Text highScoreText;
    
    private void Start()
    {
        highScoreText = GetComponent<Text>();
       
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
