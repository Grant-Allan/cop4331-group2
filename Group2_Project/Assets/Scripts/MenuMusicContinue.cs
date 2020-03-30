using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicContinue : MonoBehaviour
{
    void Awake()
    {
        GameObject[] song = GameObject.FindGameObjectsWithTag("menuMusic");
        if (song.Length > 1)
            Destroy(this.gameObject);

        GameObject gameSong = GameObject.FindGameObjectWithTag("gameMusic");
        Destroy(gameSong);

        DontDestroyOnLoad(this.gameObject);
    }
}
