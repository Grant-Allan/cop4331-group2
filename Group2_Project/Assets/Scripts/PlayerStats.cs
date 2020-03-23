using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    public static int health, score;
    public static bool pass;
    public static bool gameDone;
    public static bool gameTimeStarted;
    public static int[] highscores = new int[3];
    public static string[] users = new string[3];
    public static int ScoreNum = 0;
}
