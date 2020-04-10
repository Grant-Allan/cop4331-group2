using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Setting : MonoBehaviour
{
    // Start is called before the first frame update
    public Text up = null;
    public Text down = null;
    public Text left = null;
    public Text right = null;
    public Text pause = null;
    private bool loop;


    private int pos_up = 0;
    private int pos_down = 0;
    private int pos_left = 0;
    private int pos_right = 0;
    private int pos_pause = 0;

    private string[] alphabet = {"RETURN", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};




	public void up_update()
	{
		up.text = alphabet[pos_up];
		pos_up += 1;
		pos_up = pos_up % 27;
	}

	public void down_update()
	{
		down.text = alphabet[pos_down];
		pos_down += 1;
		pos_down = pos_down % 27;
	}

	public void left_update()
	{		
		left.text = alphabet[pos_left];
		pos_left += 1;
		pos_left = pos_left % 27;
	}

	public void right_update()
	{
		right.text = alphabet[pos_right];
		pos_right += 1;
		pos_right = pos_right % 27;
	}

	public void pause_update()
	{
		pause.text = alphabet[pos_pause];
		pos_pause += 1;
		pos_pause = pos_pause % 27;
	}




}
