using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//controls the timer at the bottom of DemoGame
public class TimeBar : MonoBehaviour
{
    //public Text timeText;
    
    public float startingTime = 3.0f;
    public Slider Timer;

    // Use this for initialization
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

            if (PlayerStats.pass == false)
            {
                PlayerStats.health -= 1;
            }
            else
            {
                PlayerStats.score += 1;
            }


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
