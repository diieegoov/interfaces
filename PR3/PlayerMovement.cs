using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;
    private float horizontal;
    private float vertical;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    // Se debe trabajar con la lectura del teclado y con las físicas en tiempos diferentes
    void FixedUpdate() {
        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y,
        movement.z * speed);
    }
}
