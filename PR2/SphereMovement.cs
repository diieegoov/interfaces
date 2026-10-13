using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed;

    private float vertical;
    private float horizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("VerticalSphere");
        horizontal = Input.GetAxis("HorizontalSphere");
        transform.Translate(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);
    }
}
