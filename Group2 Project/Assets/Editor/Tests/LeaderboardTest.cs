using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using NUnit.Framework;

public class LeaderboardTest 
{
    public Button LeaderboardButton;

    [Test]
    public void TestLeaderboardButton_ToLeaderboardScreen ()
    {

        LeaderboardButton.onClick.Invoke();

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        Assert.IsTrue(sceneName == "2 Leaderboard");


    }
}
