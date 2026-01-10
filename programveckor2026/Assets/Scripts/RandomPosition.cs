using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField]
    int maxTop;
    [SerializeField]
    int minTop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(-10, 0);
        var newpos = new Vector2(-10, Random.value);
    }
    int r = Random.Range(-3, 5);
    int fps = 0;
    // Update is called once per frame
    void Update()
    {
        fps++;
        if (fps == 60)
        {
            fps = 0;
            r = Random.Range(minTop, maxTop);
            transform.position = new Vector2(-10, r);
        }

    }
}
