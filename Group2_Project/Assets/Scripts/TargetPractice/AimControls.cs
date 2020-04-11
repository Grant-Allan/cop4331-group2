using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AimControls : MonoBehaviour
{



    private int rng;

    private float init_x, init_y;

    private Vector3 updated_position;

    public Text AimText;
    public Text BullsEyeText;

    void Start()
    {
        updated_position = transform.position;


	init_x = UnityEngine.Random.Range(0f, 1f) * (9.28f + 7.4f) - 7.4f; 
	init_y = UnityEngine.Random.Range(0f, 1f) * (1.5f + 5.39f) - 1.5f; 

	updated_position.x = init_x;
	updated_position.y = init_y;

	transform.position = updated_position;

	AimText.gameObject.SetActive(true);
	BullsEyeText.gameObject.SetActive(false);	
	PlayerStats.gameTimeStarted = true;
    }

    void Update()
    {

	if (!PlayerStats.gameDone)
	{

        if (Input.GetKey("d") & !PlayerStats.gameDone)
        {
            updated_position.x += 7 * Time.deltaTime;
        }
        if (Input.GetKey("a") & !PlayerStats.gameDone)
        {
            updated_position.x -= 7 * Time.deltaTime;
        }
        if (Input.GetKey("w") & !PlayerStats.gameDone)
        {
            updated_position.y += 7 * Time.deltaTime;
        }
        if (Input.GetKey("s") & !PlayerStats.gameDone)
        {
            updated_position.y -= 7 * Time.deltaTime;
        }

        transform.position = updated_position;
	}

	 if (Input.GetKeyDown("space"))
        {
            PlayerStats.gameDone = true;
        }

	
	if(PlayerStats.gameDone)
	{
		//bullseye
		if(Math.Sqrt(Math.Pow( transform.position.x - 0.9f, 2) + Math.Pow( transform.position.y - 0.4f, 2)) < 0.4f)
		{

	AimText.gameObject.SetActive(false);
	BullsEyeText.gameObject.SetActive(true);
			
		}

		//passed
		if(Math.Sqrt(Math.Pow(transform.position.x - 0.9f, 2) + Math.Pow(transform.position.y - 0.4f, 2)) < 1.82f)
		{
			PlayerStats.pass = true;

		}
		else
		{
			PlayerStats.pass = false;
		}

	}
	

    }
}
