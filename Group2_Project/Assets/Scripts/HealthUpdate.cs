using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpdate : MonoBehaviour
{

    public int health;
    public Sprite heart;
    private SpriteRenderer currRenderer;

    public GameObject heart1, heart2, heart3;

    void Start()
    {
        health = PlayerStats.health;

        if (health >= 1)
        {
            currRenderer = heart1.GetComponent<SpriteRenderer>();
            currRenderer.sprite = heart;
        }

        if (health >= 2)
        {
            currRenderer = heart2.GetComponent<SpriteRenderer>();
            currRenderer.sprite = heart;
        }

        if (health >= 3)
        {
            currRenderer = heart3.GetComponent<SpriteRenderer>();
            currRenderer.sprite = heart;
        }

    }

}
