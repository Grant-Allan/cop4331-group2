using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonDisappear : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            gameObject.SetActive(false);
        }
        
    }
}
