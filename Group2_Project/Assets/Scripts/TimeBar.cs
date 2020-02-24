using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    private Slider slider;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Minus time from the bar
    public void DecreaseTime(float time)
    {
        slider.value -= time;
    }
}
