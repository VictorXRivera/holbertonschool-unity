using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 500f;
    private int score = 0;
    private int health = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            Destroy(other.gameObject);
            score += 1;
            Debug.Log($"Score: {score}");
        }

        if (other.gameObject.tag == "Trap")
        {
            health -=1;
            Debug.Log($"Health: {health}");
        }

        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene("maze");
        }
    }

    void Update()
    {
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("maze");
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("d"))
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey("a"))
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(0, 0, -500 * Time.deltaTime);
    }
}