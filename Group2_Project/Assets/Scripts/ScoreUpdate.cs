using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text mytext = null;
    void Start()
    {
        //stores the current score as a string variable for updating score in the transition screen
        mytext.text = PlayerStats.score.ToString();
    }
}
