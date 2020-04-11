using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PersonBalloonMovement : MonoBehaviour
{
    public float speed = 6;
    public bool balloonpop = false;
    public float startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().gravityScale = -0.25f;

        BalloonPopData.person_pos = transform.position.x;

        if (Input.GetKeyDown("space"))
        {
            PlayerStats.gameDone = true;
            balloonpop = true;
        }


        if (balloonpop != true)
        {

            // When left is pressed move object to the left of the screen.
            if (Input.GetKeyDown("a"))
                GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;

            // When right is pressed move object to the left of the screen.
            if (Input.GetKeyDown("d"))
                GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;

            // Go right if the postion is at the left boundary.
            if (transform.position.x <= -8)
                GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;

            // Go left if the postion is at the right boundary.
            if (transform.position.x >= 8)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);

            GetComponent<Rigidbody2D>().gravityScale = 10;

            if (Math.Abs(BalloonPopData.cloud_pos - BalloonPopData.person_pos) <= 1.0f)
            {
                PlayerStats.pass = true;
            }
            else
            {
                PlayerStats.pass = false;
            }

            // Freeze sprite at its starting position
            if (transform.position.y < startPosition)
            {
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            }
        }
    }
}
