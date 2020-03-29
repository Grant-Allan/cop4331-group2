using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLeaderboard : MonoBehaviour
{

    public Text name1 = null;
    public Text name2 = null;
    public Text name3 = null;
    public Text score1 = null;
    public Text score2 = null;
    public Text score3 = null;

    private string temp_name;
    private int temp_score;

    // Start is called before the first frame update
    void Start()
    {
        SortLeaderboard();

	if (PlayerStats.highscores[0] != -1)
	{
		name1.text = PlayerStats.users[0];
		score1.text = PlayerStats.highscores[0].ToString();
	}
	if (PlayerStats.highscores[1] != -1)
	{
		name2.text = PlayerStats.users[1];
		score2.text = PlayerStats.highscores[1].ToString();
	}
	if (PlayerStats.highscores[2] != -1)
	{
		name3.text = PlayerStats.users[2];
		score3.text = PlayerStats.highscores[2].ToString();
	}

	
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SortLeaderboard()
    {
    if (PlayerStats.ScoreNum == 2)
	{
		if (PlayerStats.highscores[0] < PlayerStats.highscores[1])
		{
			temp_name = PlayerStats.users[0];
			temp_score = PlayerStats.highscores[0];

			PlayerStats.users[0] = PlayerStats.users[1];
			PlayerStats.highscores[0] = PlayerStats.highscores[1];

			
			PlayerStats.users[1] = temp_name;
			PlayerStats.highscores[1] = temp_score;
		}
	}

        if (PlayerStats.ScoreNum == 3)
	{
		if (PlayerStats.highscores[0] < PlayerStats.highscores[2])
		{
			temp_name = PlayerStats.users[1];
			temp_score = PlayerStats.highscores[1];

			PlayerStats.users[1] = PlayerStats.users[2];
			PlayerStats.highscores[1] = PlayerStats.highscores[2];

			
			PlayerStats.users[2] = temp_name;
			PlayerStats.highscores[2] = temp_score;

			temp_name = PlayerStats.users[0];
			temp_score = PlayerStats.highscores[0];

			PlayerStats.users[0] = PlayerStats.users[1];
			PlayerStats.highscores[0] = PlayerStats.highscores[1];
			
			PlayerStats.users[1] = temp_name;
			PlayerStats.highscores[1] = temp_score;
		}
		else
		{
			
			if (PlayerStats.highscores[1] < PlayerStats.highscores[2])
			{
				temp_name = PlayerStats.users[1];
				temp_score = PlayerStats.highscores[1];

				PlayerStats.users[1] = PlayerStats.users[2];
				PlayerStats.highscores[1] = PlayerStats.highscores[2];

			
				PlayerStats.users[2] = temp_name;
				PlayerStats.highscores[2] = temp_score;
			}

		}
	}
    }

}
