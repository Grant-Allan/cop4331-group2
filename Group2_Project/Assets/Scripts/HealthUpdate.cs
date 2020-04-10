using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpdate : MonoBehaviour
{


    public int health, score;
    public Sprite heart, speed, up;
    private SpriteRenderer currRenderer;

    public GameObject heart1, heart2, heart3, speed_sprite, up_sprite;

    void Start()
    {


        health = PlayerStats.health;

	score = PlayerStats.score;


	if (score == 0)
	{
		PlayerStats.displayed_speed = 0;
	}

	if (score % 5 == 0 & score != 0 & PlayerStats.displayed_speed == 0)
	{


		currRenderer = speed_sprite.GetComponent<SpriteRenderer>();
		currRenderer.sprite = speed;

		currRenderer = up_sprite.GetComponent<SpriteRenderer>();
		currRenderer.sprite = up;

		PlayerStats.time_factor = PlayerStats.time_factor + 0.2f;


		PlayerStats.displayed_speed = 1;
	}
	else
	{
		PlayerStats.displayed_speed = 0;
	}


	Time.timeScale = PlayerStats.time_factor;

        
        if (health >= 1) // then render leftmost heart
        {
            currRenderer = heart1.GetComponent<SpriteRenderer>();
            currRenderer.sprite = heart;
        }
        
        if (health >= 2) // then render middle heart
        {
            currRenderer = heart2.GetComponent<SpriteRenderer>();
            currRenderer.sprite = heart;
        }

        if (health >= 3) // then render rightmost heart
        {
            currRenderer = heart3.GetComponent<SpriteRenderer>();
            currRenderer.sprite = heart;
        }

    }

}
