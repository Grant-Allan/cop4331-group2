using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinWheel : MonoBehaviour
{
    Transform our_transform;
    float speed;
    public Text score_win;
    public Text heart_win;
    public bool reward_given;

    // Start is called before the first frame update
    void Start()
    {
        our_transform = GetComponent<Transform>();
	speed = 4.0f;
	heart_win.gameObject.SetActive(false);
	score_win.gameObject.SetActive(false);
	reward_given = false;
    }

    // Update is called once per frame
    void Update()
    {

	WheelStats.wheel_pos = our_transform.rotation.z;

	if (!PlayerStats.gameDone)
	{
        	our_transform.Rotate(0, 0, speed);
		speed /= 1.02f;
	}


	if (PlayerStats.gameDone)
	{


		PlayerStats.pass = true;

		if (0f <= WheelStats.wheel_pos && WheelStats.wheel_pos <0.36f)
		{
			WheelStats.heart = true;
		}
		else if (0.70f <= WheelStats.wheel_pos && WheelStats.wheel_pos <0.92f)
		{
			WheelStats.heart = true;
		}
		else
		{
			WheelStats.heart = false;
		}
		
	}

	if (WheelStats.heart & PlayerStats.gameDone & !reward_given)
	{
		heart_win.gameObject.SetActive(true);

		if (PlayerStats.health <3)
		{
			PlayerStats.health += 1;
		}

		reward_given = true;

	}
	else if (!WheelStats.heart & PlayerStats.gameDone & !reward_given)
	{
		score_win.gameObject.SetActive(true);
		PlayerStats.score += 4;
		reward_given = true;
	}


    }
}
