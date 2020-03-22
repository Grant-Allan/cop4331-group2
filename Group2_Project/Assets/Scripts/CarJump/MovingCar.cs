using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    public float speed = 8;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.pass = true;
        PlayerStats.gameTimeStarted = true;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * (speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("hit");
        PlayerStats.pass = false;
    }


}
