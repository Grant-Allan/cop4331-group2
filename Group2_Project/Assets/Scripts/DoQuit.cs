using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoQuit : MonoBehaviour
{
    // Start is called before the first frame update
    public void do_quit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
