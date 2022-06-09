using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    public Timer TimerScript;
    public GameObject Player;

    void Start()
    {
        TimerScript = Player.GetComponent<Timer>();
    }

    void OnTriggerExit(Collider collider)
    {
        TimerScript.enabled = true;

        gameObject.SetActive(false);
    }
}
