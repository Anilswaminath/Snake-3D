using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreSystem
{
    public static int redFruitValue = 15;
    public static int blueFruitValue = 20;
    public static int scoretotal;
    public static int score;
    public static void AddScoreRed()
    {

        score = ScoreStreak.redScore;
        scoretotal += score;

    }
    public static void AddScoreBlue()
    {

        score = ScoreStreak.blueScore;
        scoretotal += score;

    }
}
