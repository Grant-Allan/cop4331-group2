using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//controls the timer at the bottom of DemoGame
public class TimeBar : MonoBehaviour
{
    //duration of DemoGame minigame
    private float startingTime = 3.0f;
    private float delay;
    private bool startedWaiting;

    public Slider Timer;

    void Start()
    {
        Timer = GetComponent<Slider>();
        startedWaiting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.gameDone == false & PlayerStats.gameTimeStarted)
        {
            startingTime -= Time.deltaTime;
            Timer.value = startingTime;
        }

        //minigame has ended due to time running out
        if (startingTime <= 0 & PlayerStats.gameDone == false & startedWaiting == false)
        {
            startedWaiting = true;
            startingTime = 0;
            delay = 0.1f;
            StartCoroutine(Wait(delay));

        }

        //minigame has ended due to user input
        if (PlayerStats.gameDone & startedWaiting == false)
        {
            startedWaiting = true;
            delay = 2.0f;
            StartCoroutine(Wait(delay));

        }


    }

    void GameResults()
    {
        Debug.Log("should only run once");

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


    IEnumerator Wait(float delay)
    {
        yield return new WaitForSeconds(delay);
        GameResults();
    }
}
