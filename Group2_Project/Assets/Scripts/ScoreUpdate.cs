using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text mytext = null;
    void Start()
    {
        mytext.text = PlayerStats.score.ToString();
    }
}
