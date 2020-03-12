using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PancakeDown : MonoBehaviour
{
    System.Random rnd = new System.Random();

    private int rng;
    private float fall_loc;
    private Vector2 final_pos;
    private float time_since_start;
    private bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        rng = rnd.Next(0, 13);
        fall_loc = -7.5f + 1.0f * rng;
        Vector3 start_pos = transform.position;
        start_pos.x = fall_loc;
        transform.position = start_pos;
        final_pos = transform.position;
        final_pos.y = -4.16f;
        CatchData.pancake_pos = transform.position.y;

        PlayerStats.pass = false;
    }

    // Update is called once per frame
    void Update()
    {
        time_since_start += Time.deltaTime;


        if ( Math.Abs(fall_loc - CatchData.chef_pos) < 0.5 & CatchData.pancake_pos >= -1.11 & Math.Abs(-1.11f - CatchData.pancake_pos) < 0.1  )
        {
            hit = true;
            PlayerStats.pass = true;
            PlayerStats.gameDone = true;
        }
        else
        {
            PlayerStats.pass = false;
        }



        if (time_since_start >= 2.0f & !hit)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), final_pos, 5 * Time.deltaTime);
            PlayerStats.gameTimeStarted = true;
        }

        CatchData.pancake_pos = transform.position.y;
    }

    IEnumerator WaitThenDrop(float delay)
    {
        yield return new WaitForSeconds(delay);

    }
}
