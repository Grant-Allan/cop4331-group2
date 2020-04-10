using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicUpdate: MonoBehaviour
{

    private bool music_on_bool;
    public Sprite music_on_sprite, music_off_sprite;
    private SpriteRenderer currRenderer;

    public GameObject music_display;

    // Start is called before the first frame update
    void Start()
    {
        music_on_bool = PlayerStats.music_on;
    }

    // Update is called once per frame
    void Update()
    {

	Debug.Log(music_on_bool);

        music_on_bool = PlayerStats.music_on;
        if (music_on_bool)
	{
		currRenderer = music_display.GetComponent<SpriteRenderer>();
		currRenderer.sprite = music_on_sprite;
	}
        else
	{
		currRenderer = music_display.GetComponent<SpriteRenderer>();
		currRenderer.sprite = music_off_sprite;
	}

    }


}
