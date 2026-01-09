using UnityEngine;

public class Movement : MonoBehaviour

{
    Rigidbody2D rb;


    float speed = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Vektor2 newPosition = transform.Position;
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector2(2, 0);
        }



    }

}
