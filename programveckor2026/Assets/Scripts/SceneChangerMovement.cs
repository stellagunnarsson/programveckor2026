using UnityEngine;

public class SceneChangerMovement : MonoBehaviour
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

        if (Input.GetKey(KeyCode.Space))
        {

            rb.linearVelocity = new Vector2(5, 0);



        }


    }
}
