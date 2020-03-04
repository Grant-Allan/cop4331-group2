using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This function is called when the quit button is pressed
public class DoQuit : MonoBehaviour
{
    public void do_quit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
