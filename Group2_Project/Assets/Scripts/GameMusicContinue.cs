using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicContinue : MonoBehaviour
{


	public AudioSource audioSource1;

    void Awake ()
    {
        GameObject[] song = GameObject.FindGameObjectsWithTag("gameMusic");
        if (song.Length > 1)
            Destroy(this.gameObject);

        GameObject menuSong = GameObject.FindGameObjectWithTag("menuMusic");
        Destroy(menuSong);

        DontDestroyOnLoad(this.gameObject);


    }





    void Update()
    {

	audioSource1.pitch = PlayerStats.time_factor;

        if (PlayerStats.music_on) {
            audioSource1.mute = false;
	}
	else
	{
	    audioSource1.mute = true;
	}
    }


}
