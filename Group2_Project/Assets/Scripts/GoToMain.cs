using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This class takes the user to main menu from the death screen after a brief delay.
public class GoToMain : MonoBehaviour
{
    public float delay = 1;
    public string nextGame = "0 Main Menu";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    //coroutine to wait a brief period and then Load the Main Menu scene
    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextGame);
    }
}
