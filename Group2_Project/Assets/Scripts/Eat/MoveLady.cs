using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLady : MonoBehaviour
{

    public SpriteRenderer hotdog1, hotdog2, hotdog3, hotdog4, hotdog5;

    private Vector2 final_pos = new Vector2(9f, 2.64f);
    private Vector2 middle = new Vector2(0.78f, 2.64f);


    void Start()
    {
        PlayerStats.gameTimeStarted = true;
    }


    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x >= -2.7 & transform.position.x <= -1.3 & Input.GetKey("space"))
        {
            hotdog1.enabled = false;
        }

        if (transform.position.x >= -1.3 & transform.position.x <= 0.1 & Input.GetKey("space"))
        {
            hotdog2.enabled = false;
        }

        if (transform.position.x >= 0.1 & transform.position.x <= 1.5 & Input.GetKey("space"))
        {
            hotdog3.enabled = false;
        }

        if (transform.position.x >= 1.5 & transform.position.x <= 2.9 & Input.GetKey("space"))
        {
            hotdog4.enabled = false;
        }

        if (transform.position.x >= 2.9 & transform.position.x <= 3.3 & Input.GetKey("space"))
        {
            hotdog5.enabled = false;
        }

        if ( !hotdog1.enabled & !hotdog2.enabled & !hotdog3.enabled & !hotdog4.enabled & !hotdog5.enabled)
        {
            PlayerStats.pass = true;
            PlayerStats.gameDone = true;
        }
        else
        {
            PlayerStats.pass = false;
        }

        if (PlayerStats.pass)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), middle, 3 * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), final_pos, 3 * Time.deltaTime);
        }

    }
}
