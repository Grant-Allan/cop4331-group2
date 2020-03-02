using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script class controls the transition screen
public class StartNextGame : MonoBehaviour
{
    // time delay on the transition screen
    public float delay = 2.0f;
    // next minigame (insert correct minigame here)
    public string nextGame = "DemoGameScene";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    // enacts delay and then loads the next game
    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextGame);
    }
}
