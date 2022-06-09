using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 0f;
    public Transform playerBody;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
    }
}