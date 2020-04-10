using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPlayerStats : MonoBehaviour
{
    void Start()
    {
        //initial player health is three
        PlayerStats.health = 3;
        //initial player score is 0
        PlayerStats.score = 0;
        //player is initialized to pass the minigame
        PlayerStats.pass = true;
	PlayerStats.time_factor = 1.0f;
	Time.timeScale = 1.0f;
    }

}
