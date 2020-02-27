using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.health = 3;
        PlayerStats.score = 0;
        Debug.Log(PlayerStats.health.ToString());
        Debug.Log(PlayerStats.score.ToString());
    }

}
