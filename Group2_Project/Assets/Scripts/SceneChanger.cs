using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    //Main Menu -> Play Button
    public void Scene2()
    {
        SceneManager.LoadScene("TransitionScene");
    }

    //Main Menu -> Leaderboard Button
    public void Leaderboard()
    {
        SceneManager.LoadScene("2 Leaderboard");
    }

    //Leaderboard -> Back Button
    public void BackToMain()
    {
        SceneManager.LoadScene("0 Main Menu");
    }

    //Main Menu -> Settings Button
    public void Settings()
    {
        
    }
}
