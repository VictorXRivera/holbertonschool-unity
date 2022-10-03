using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float time;

    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
        string hours = Mathf.Floor((time % 216000)/3600).ToString("0");
        string minutes = Mathf.Floor((time % 3600)/60).ToString("00");
        string seconds = (time % 60).ToString("00");
        timerText.text = hours + ":" + minutes + "." + seconds;
    }
}