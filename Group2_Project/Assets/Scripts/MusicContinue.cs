using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContinue : MonoBehaviour
{
    void Awake ()
    {
        GameObject[] song = GameObject.FindGameObjectsWithTag("gameMusic");
        if (song.Length > 1)
            Destroy(this.gameObject);

        GameObject[] menuSong = GameObject.FindGameObjectsWithTag("menuMusic");
        if (menuSong.Length > 0)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}
