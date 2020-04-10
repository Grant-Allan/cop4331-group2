using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 8;
    public float accelerationTime = 0.5f;
    private float timeLeft;
    private int randomDir;
    public bool balloonpop = false;


    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.gameTimeStarted = true;
        PlayerStats.pass = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            balloonpop = true;
        }

        //Creating random movement for cloud
        timeLeft -= (Time.deltaTime * 2);
        randomDir = Random.Range(0, 2) * 2 - 1;

        GetComponent<Rigidbody2D>().gravityScale = 0;

        BalloonPopData.cloud_pos = transform.position.x;

        if (balloonpop == false)
        {
            if (timeLeft <= 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(randomDir, 0) * (speed / 2);
                timeLeft += accelerationTime;
            }

            // Go right if the postion is at the left boundary.
            if (transform.position.x <= -8)
                GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * (speed / 2);

            // Go left if the postion is at the right boundary.
            if (transform.position.x >= 8)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * (speed / 2);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
