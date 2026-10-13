using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed;
    public Transform sphere;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = sphere.position;

        // El cubo gira para mirar hacia la esfera
        transform.LookAt(target);

        // Calculamos la dirección hacia la esfera
        Vector3 direction = target - transform.position;
        direction = direction.normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
