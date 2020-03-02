using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoQuit : MonoBehaviour
{
    // This function is called when the quit button is pressed
    public void do_quit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
