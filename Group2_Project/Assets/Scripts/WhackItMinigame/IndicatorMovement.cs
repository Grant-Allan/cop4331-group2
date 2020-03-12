using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorMovement : MonoBehaviour
{

    private Vector3 pos1 = new Vector3(-3, -3, 0);
    private Vector3 pos2 = new Vector3(3, -3, 0);
    public float speed = 1.0f;

    void Start()
    {
        PlayerStats.gameTimeStarted = true;
    }


    void Update()
    {
        if (WhackData.moving == true)
        {
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        }

        if (Input.GetKey("space"))
        {
            WhackData.moving = false;
            WhackData.pos = transform.position.x;
        }
    }
}
