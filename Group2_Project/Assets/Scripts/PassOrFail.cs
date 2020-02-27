using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassOrFail : MonoBehaviour
{
    // Start is called before the first frame update


    public void pass()
    {
        PlayerStats.pass = true;
    }

    public void fail()
    {
        PlayerStats.pass = false;
    }
}
