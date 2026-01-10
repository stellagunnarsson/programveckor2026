using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    GameObject vägg;
    private void OnCollisionenter2D(Collision2D collision)
    {
        Debug.Log(vägg + collision.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
