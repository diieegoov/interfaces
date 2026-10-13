
using UnityEngine;

public class LaunchObject : MonoBehaviour
{
    public float force = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(Vector3.left * force, ForceMode.Impulse);
        }
    }
}