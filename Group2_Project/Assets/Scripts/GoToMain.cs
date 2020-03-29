using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This class takes the user to main menu from the death screen after a brief delay.
public class GoToMain : MonoBehaviour
{
    public float delay = 1;
    void Start()
    {
        if (PlayerStats.ScoreNum < 3 || PlayerStats.highscores[2] < PlayerStats.score)
        {
            StartCoroutine(LoadLevelAfterDelay(delay, "NewHighScore"));
        }
        else
        {
            StartCoroutine(LoadLevelAfterDelay(delay, "0 Main Menu"));
        }


    }

    //coroutine to wait a brief period and then Load the Main Menu scene
    IEnumerator LoadLevelAfterDelay(float delay, string level)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(level);
    }
}
