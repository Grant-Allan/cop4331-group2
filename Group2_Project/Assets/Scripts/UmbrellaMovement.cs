using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaMovement : MonoBehaviour
{
    public float speed = 6;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * (speed / 3);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;

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
}