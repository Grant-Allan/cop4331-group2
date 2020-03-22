using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonJump : MonoBehaviour
{

    public float speed = 8;
    public float startPosition;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        startPosition = transform.position.y;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        // If space is pressed, make the sprite jump
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * (speed);
        }

        // Freeze sprite at its starting position
        if (transform.position.y < startPosition)
        {
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }

      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("hit");
        GetComponent<Rigidbody2D>().angularVelocity = 180;
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * (speed);
    }

}
