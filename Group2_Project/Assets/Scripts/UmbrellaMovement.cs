﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaMovement : MonoBehaviour
{
    public float speed = 9;


    void Update()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;

        // When left is pressed move object to the left of the screen.
        if (Input.GetKeyDown("a"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;

        // When right is pressed move object to the left of the screen.
        if (Input.GetKeyDown("d"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;

        // Go up if the postion is at the left boundary.
        if (transform.position.x <= -8)
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;

        // Go down if the postion is at the right boundary.
        if (transform.position.x >= 8)
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;
    }
}