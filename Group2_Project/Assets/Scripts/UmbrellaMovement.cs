using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaMovement : MonoBehaviour
{
    public float speed = 9;


    void Update()
    {
        // When left is pressed move object to the left of the screen.
        if (Input.GetKeyDown("a"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;

        // When right is pressed move object to the left of the screen.
        if (Input.GetKeyDown("d"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;

        // Go up if the postion is below or at the bottom boundary.
        if (transform.position.y <= -4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;

        // Go down if the postion is above or at the top boundary.
        if (transform.position.y >= 4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
    }
}