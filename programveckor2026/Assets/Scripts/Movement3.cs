using UnityEngine;

public class Movement3 : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 8.399)
            {
                rb.linearVelocity = new Vector2(5, 0);
            }

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -8.399)
            {
                rb.linearVelocity = new Vector2(-5, 0);
            }

        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 4.5)
            {
                rb.linearVelocity = new Vector2(0, 5);
            }

        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -4.5)
            {
                rb.linearVelocity = new Vector2(0, -5);
            }


        }

    }
}
