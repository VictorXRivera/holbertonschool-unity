using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 500f;
    private int score = 0;
    private int health = 5;
    public Text scoreText;
    public Text healthText;
    public Text winLoseText;
    public Image winLoseBG;

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            Destroy(other.gameObject);
            score += 1;
            SetScoreText();
        }

        if (other.gameObject.tag == "Trap")
        {
            health -=1;
            SetHealthText();
        }

        if (other.gameObject.tag == "Goal")
        {
            winLoseBG.gameObject.SetActive(true);
            winLoseText.color = Color.black;
            winLoseBG.color = Color.green;
            winLoseText.text = "You win!";
            StartCoroutine(LoadScene(3));
        }
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (health == 0)
        {
            winLoseBG.gameObject.SetActive(true);
            winLoseText.color = Color.white;
            winLoseBG.color = Color.red;
            winLoseText.text = "Game Over!";
            StartCoroutine(LoadScene(3));
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