using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreakText : MonoBehaviour
{
    public static StreakText instance;
    public Text RedStreak;
    public Text BlueStreak;
    private void Start()
    {
        instance = this;
    } 
    void Update()
    {
        RedStreak.text = ScoreStreak.redStreak.ToString();
        BlueStreak.text = ScoreStreak.blueStreak.ToString();
    }
}
