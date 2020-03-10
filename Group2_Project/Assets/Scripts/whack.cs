using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whack : MonoBehaviour
{
    private bool hasWhacked = false;
    public TriggerWhack other;

    void Update()
    {
        if (WhackData.moving == false & hasWhacked == false)
        {
            transform.Rotate(Vector3.forward * -45);
            hasWhacked = true;
            PlayerStats.gameDone = true;

            if (WhackData.pos <= -2 | WhackData.pos >= 2)
            {
                PlayerStats.pass = false;
                other.WorstWhack();
            }
            else if (WhackData.pos <= -0.8 | WhackData.pos >= 0.8)
            {
                PlayerStats.pass = true;
                other.MediumWhack();

            }
            else
            {
                PlayerStats.pass = true;
                other.Whacked();
            }
            
        }

    }
}
