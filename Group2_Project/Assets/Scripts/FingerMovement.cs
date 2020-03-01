using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerMovement : MonoBehaviour
{
    public GameObject earFungus;
    public Transform fungusPos;
    public float speed = 9;
    public bool triggered = false;

    void OnTriggerEnter2D()
    {
        triggered = true;

        // If the object collides pull it back to the middle of the screen.
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * (speed - 3);

        // Spawn the ear fungus at end of finger
        earFungus = Instantiate(earFungus, fungusPos.position, fungusPos.rotation);
        earFungus.transform.parent = transform;
    }

    void Update()
    {
        // Stop object in middle of screen
        if (triggered && (transform.position.x <= 0.55 && transform.position.x >= -0.55))
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;

        // When space is pressed move object to the left of the screen.
        if ((triggered == false) && Input.GetKeyDown("space"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * (speed + 3);

        // Go up if the postion is below or at the bottom boundary.
        if (transform.position.y <= -4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;

        // Go down if the postion is above or at the top boundary.
        if (transform.position.y >= 4)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
    }
}
