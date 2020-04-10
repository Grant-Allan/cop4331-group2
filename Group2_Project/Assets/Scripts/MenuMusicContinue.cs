using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicContinue : MonoBehaviour
{

	public AudioSource audioSource1;
	public AudioSource audioSource2;

    void Awake()
    {

	        GameObject[] song = GameObject.FindGameObjectsWithTag("menuMusic");
	        if (song.Length > 1)
	            Destroy(this.gameObject);

	        GameObject gameSong = GameObject.FindGameObjectWithTag("gameMusic");
	        Destroy(gameSong);

	        DontDestroyOnLoad(this.gameObject);

    }



    void Start()
    {
        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (PlayerStats.music_on) {
            audioSource1.mute = false;
	}
	else
	{

	    Debug.Log("this shouldnt happen");
	    audioSource1.mute = true;
	}
    }




}
