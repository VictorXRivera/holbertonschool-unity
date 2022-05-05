using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotate;
    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime, 0, 0);
    }
}