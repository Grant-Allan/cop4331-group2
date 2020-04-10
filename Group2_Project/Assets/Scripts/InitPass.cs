using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //At the beginning of a minigame, reset PlayerStats.pass
        PlayerStats.pass = true;

	Time.timeScale = PlayerStats.time_factor;
    }
}
