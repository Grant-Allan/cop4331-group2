using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float speed = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randDir = Random.Range(1, 3);

        GetComponent<Rigidbody2D>().gravityScale = 0;

        //Left
        if (randDir == 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * speed;
        }

        //Right
        if (randDir == 2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
        }

    }
}
