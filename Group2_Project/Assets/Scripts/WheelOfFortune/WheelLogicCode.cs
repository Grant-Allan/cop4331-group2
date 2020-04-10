using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelLogicCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.gameTimeStarted = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            PlayerStats.gameDone = true;
        }


    }
}
