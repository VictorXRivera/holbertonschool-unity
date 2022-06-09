using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform track_player;
    public Vector3 offset;

    void Update()
    {
        transform.position = track_player.position + offset;
    }
}