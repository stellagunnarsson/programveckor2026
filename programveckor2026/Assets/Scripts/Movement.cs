using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rb;

    float speed = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.linearVelocityX = 0;
            rb.linearVelocityY = speed;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocityY = 0;
            rb.linearVelocityX = speed;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.linearVelocityY = -speed;
            rb.linearVelocityX = 0;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.linearVelocityX = -speed;
            rb.linearVelocityY = 0;
        }
    }
}
