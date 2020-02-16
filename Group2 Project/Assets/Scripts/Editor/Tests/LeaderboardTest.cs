using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using NUnit.Framework;

public class LeaderboardTest 
{

    [Test]
    public void TestLeaderboardButton_ToLeaderboardScreen ()
    {
        Button leaderboardButton;

        leaderboardButton = GameObject.Find("LeaderboardButton").GetComponent<Button>();

        leaderboardButton.onClick.AddListener(() => GoToLeaderboard());

        leaderboardButton.onClick.Invoke();

        Scene currentScene = EditorSceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        Assert.IsTrue(sceneName == "2 Leaderboard");

    }

    public void GoToLeaderboard()
    {
        EditorSceneManager.OpenScene("2 Leaderboard");
    }
}
