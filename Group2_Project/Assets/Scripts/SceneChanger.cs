using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void Scene2()
    {
        SceneManager.LoadScene("TransitionScene");
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("2 Leaderboard");
    }


    public void BackToMain()
    {
        SceneManager.LoadScene("0 Main Menu");
    }


    public void Settings()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
