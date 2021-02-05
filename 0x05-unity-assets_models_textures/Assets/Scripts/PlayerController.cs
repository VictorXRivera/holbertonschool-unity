using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 0f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    bool isGrounded;

    public Transform groundCheck;
    public float groundDistance = 0f;
    public LayerMask groundMask;

    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(0, 1.4f, 0);
    }
    void Update()
    {


        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.right * horizontal + transform.forward * vertical;

        controller.Move(direction * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}