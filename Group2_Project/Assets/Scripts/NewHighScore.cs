using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewHighScore : MonoBehaviour
{
    public InputField input;

    void Start()
    {
        var se = new InputField.SubmitEvent();
        se.AddListener(EnterInitials);
        input.onEndEdit = se;
    }

    private void EnterInitials(string name)
    {
        if (PlayerStats.ScoreNum < 3)
        {
            PlayerStats.users[PlayerStats.ScoreNum] = name;
            PlayerStats.highscores[PlayerStats.ScoreNum] = PlayerStats.score;
            PlayerStats.ScoreNum += 1;
        }
        else
        {
            if (PlayerStats.score > PlayerStats.highscores[2])
            {
                PlayerStats.users[2] = name;
                PlayerStats.highscores[2] = PlayerStats.score;
            }
        }

        SceneManager.LoadScene("2 Leaderboard");

    }




void Update()
    {
        
    }
}
