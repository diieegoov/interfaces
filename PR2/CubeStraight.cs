using UnityEngine;

public class CubeStraight : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        // Girar el cubo
        transform.Rotate(0, horizontal, 0);

        // Avanzar hacia su propio eje Z positivo
        transform.position += transform.forward * speed * Time.deltaTime;

        // Dibujar la dirección hacia delante
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }
}
