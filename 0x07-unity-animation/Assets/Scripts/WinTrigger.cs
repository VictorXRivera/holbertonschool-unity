using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Changes display of timer once player hits flag
public class WinTrigger : MonoBehaviour
{
    public Text TimerText;
    public Timer TimerScript;
    public GameObject Player;
    public Canvas WinCanvas;

    // Start is called before the first frame update
    void Start()
    {
       TimerScript = Player.GetComponent<Timer>();
    }

    // When player touches flag
    private void OnTriggerEnter(Collider collider)
    {
        TimerScript.enabled = false;
        TimerText.fontSize = 80;
        TimerText.color = Color.green;
        WinCanvas.gameObject.SetActive(true);
    }
}