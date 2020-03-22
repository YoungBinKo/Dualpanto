using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static int score; //static int meaning : we can make this accessable by calling
    public static int ScoreToReach;

    public static void AddScore(int amount)//static int must with static function
    {
        score += amount;
        Debug.Log("Current Score: " + score);//bc can not check static int score
        UIManager.instance.UpdateUI(score, ScoreToReach);
    }

    public static int ReadScore()
    {
        return score;
    }
}
