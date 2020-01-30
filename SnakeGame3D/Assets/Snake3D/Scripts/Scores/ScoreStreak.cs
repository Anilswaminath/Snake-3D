using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreStreak
{
    public static int redStreak = 0;
    public static int blueStreak = 0;
    public static int redScore;
    public static int blueScore;
    
    public static void RedScoreStreak()
    {
        redStreak += 1;
        redScore = redStreak * ScoreSystem.redFruitValue;
    }
    public static void BlueScoreStreak()
    {
        blueStreak += 1;
        blueScore = blueStreak * ScoreSystem.blueFruitValue;
    }
}
