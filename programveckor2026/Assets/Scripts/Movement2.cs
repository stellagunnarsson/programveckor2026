using UnityEngine;

public class Movement2 : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject dialoguePanel;
    public GameObject dialoguePanel2;
    public GameObject dialoguePanel3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!dialoguePanel.activeInHierarchy || !dialoguePanel2.activeInHierarchy || !dialoguePanel3.activeInHierarchy)
        {
            rb.linearVelocity = new Vector2(0, 0);

        }
        else
        {
            rb.linearVelocity = new Vector2(0, 0);

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                if (transform.position.x < 8.27)
                {
                    rb.linearVelocity = new Vector2(5, 0);
                }


            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                if (transform.position.x > -8.27)
                {
                    rb.linearVelocity = new Vector2(-5, 0);
                }


            }
        }
    }
}
