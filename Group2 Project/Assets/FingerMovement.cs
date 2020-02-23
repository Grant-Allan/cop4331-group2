using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerMovement : MonoBehaviour
{
    public float speed = 9;
    

    void Update()
    {
        // When space is pressed move object to the left of the screen.
        if (Input.GetKeyDown("space"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;

        // If the object reaches left boundary pull it back to the middle of the screen.
        if (transform.position.x <= -7.95)
        {
            if (transform.position.x >= 0)
                GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
        }

        // Go up if the postion is below or at the bottom boundary.
        if (transform.position.y <= -4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;

        // Go down if the postion is above or at the top boundary.
        if (transform.position.y >= 4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
    }
}

