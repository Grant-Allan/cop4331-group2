using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pancake_up : MonoBehaviour
{

    private Vector2 air = new Vector2(2.91f, 10f);

    void Update()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), air, 5 * Time.deltaTime);
    }
}
