using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicContinue : MonoBehaviour
{
    void Awake ()
    {
        GameObject[] song = GameObject.FindGameObjectsWithTag("gameMusic");
        if (song.Length > 1)
            Destroy(this.gameObject);

        GameObject menuSong = GameObject.FindGameObjectWithTag("menuMusic");
        Destroy(menuSong);

        DontDestroyOnLoad(this.gameObject);
    }
}
