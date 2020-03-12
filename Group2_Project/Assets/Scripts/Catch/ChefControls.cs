using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefControls : MonoBehaviour
{

    private Vector3 updated_position;

    void Start()
    {
        updated_position = transform.position;
        System.Threading.Thread.Sleep(1000);
        CatchData.chef_pos = updated_position.x - 1.96f;
    }

    void Update()
    {


        if (Input.GetKey("d") & !PlayerStats.gameDone)
        {
            updated_position.x += 7 * Time.deltaTime;
        }
        if (Input.GetKey("a") & !PlayerStats.gameDone)
        {
            updated_position.x -= 7 * Time.deltaTime;
        }

        transform.position = updated_position;

        CatchData.chef_pos = updated_position.x - 1.96f;

    }
}
