using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System;

public class Timer : MonoBehaviour
{
    public Text TimerText;

    public Stopwatch timer;

    void Start()
    {
        timer = new Stopwatch();
        timer.Start();
    }

    void Update()
    {
        TimeSpan timespan = timer.Elapsed;
        TimerText.text = string.Format ("{0:00}:{1:00}.{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10);
    }
}