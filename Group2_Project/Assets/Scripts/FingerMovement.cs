using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerMovement : MonoBehaviour
{
    public float speed = 9;

    void OnTriggerEnter2D(Collision2D collision)
    {
        // If the object collides pull it back to the middle of the screen.
        //if (transform.position.x >= 0)
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
    }

    void Update()
    {
        // When space is pressed move object to the left of the screen.
        if (Input.GetKeyDown("space"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * (speed + 3);

        // Go up if the postion is below or at the bottom boundary.
        if (transform.position.y <= -4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;

        // Go down if the postion is above or at the top boundary.
        if (transform.position.y >= 4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
    }
}
