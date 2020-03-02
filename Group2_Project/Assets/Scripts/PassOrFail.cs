using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassOrFail : MonoBehaviour
{

    //the Player has passed their minigame.
    public void pass()
    {
        PlayerStats.pass = true;
    }

    //The Player has failed their minigame.
    public void fail()
    {
        PlayerStats.pass = false;
    }
}
