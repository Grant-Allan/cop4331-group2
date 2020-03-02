using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//controls the timer at the bottom of DemoGame
public class TimeBar : MonoBehaviour
{
    //duration of DemoGame minigame
    public float startingTime = 3.0f;
    public Slider Timer;

    void Start()
    {
        Timer = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        startingTime -= Time.deltaTime;
        Timer.value = startingTime;

        if (startingTime <= 0)
        {
            startingTime = 0;

            // If the player does not pass the game
            if (PlayerStats.pass == false)
            {
                //player health decreases by 1
                PlayerStats.health -= 1;
            }
            else // The player passes the game
            {
                // Player score increases by 1
                PlayerStats.score += 1;
            }

            //If the Player died during this minigame
            if (PlayerStats.health == 0)
            {
                SceneManager.LoadScene("DeathScene");
            }
            else
            {
                SceneManager.LoadScene("TransitionScene");
            }
        }
    }
}
