using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //TIMER
    int playtime = 60;
    int seconds, minutes;

    //LEVEL
    int curLevel = 1;
    int baseScore = 100;
    int scoreToReach;

    void Start()
    {
        scoreToReach = curLevel * baseScore;
        ScoreManager.ScoreToReach = scoreToReach;
        UIManager.instance.UpdateUI(0, scoreToReach);
        StartCoroutine("PlayTimer");
    }

    IEnumerator PlayTimer()
    {
        while (playtime > 0)
        {
            yield return new WaitForSeconds(1);
            playtime--;
            seconds = playtime % 60;
            minutes = playtime / 60 % 60;
            //UPDATE UI
            UIManager.instance.UpdateTime(minutes, seconds);
        }
        Debug.Log("Timer has ended");
        //WIN CONDITION
        CheckForWin();

    }

    void CheckForWin()
    {
        if(ScoreManager.ReadScore() >= scoreToReach)
        {
            Debug.Log("You won the Level");
        }
        else
        {
            //GameOver
            Debug.Log("Game Over");
        }
    }
}
