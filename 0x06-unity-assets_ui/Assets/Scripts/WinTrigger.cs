using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Changes display of timer once player hits flag
public class WinTrigger : MonoBehaviour
{
    public Text timerText;
    public Canvas WinCanvas;

    void OnTriggerEnter(Collider change)
    {
        if (change.name == "Player")
        {
            change.gameObject.GetComponent<Timer>().enabled = false;
            timerText.fontSize = 84;
            timerText.color = Color.green;
            WinCanvas.enabled = true;
        }
    }
}