using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNextGame : MonoBehaviour
{
    public float delay = 2.0f;
    string[] minigames = { "WhackItMinigame", "Eat"};

    //get random minigame
    System.Random rnd = new System.Random();

    
    public string nextGame;

    private int game_idx;

    void Start()
    {
        //reset key PlayerStats properties
        PlayerStats.gameDone = false;


        //reset key minigame properties
        WhackData.moving = true;


        //pick next game
        game_idx = rnd.Next(0, minigames.Length);
        nextGame = minigames[game_idx];
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextGame);
    }
}
