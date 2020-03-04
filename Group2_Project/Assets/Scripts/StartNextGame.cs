using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNextGame : MonoBehaviour
{
    public float delay = 2.0f;
    string[] minigames = {"DemoGameScene"};

    //get random minigame
    System.Random rnd = new System.Random();
    //public int game_idx = rnd.Next(0, minigame_num);

    //public string nextGame = minigames[game_idx];
    
    public string nextGame;

    private int game_idx;

    void Start()
    {
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
