using UnityEngine;

public class CollisionColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + collision.gameObject.name);
        Renderer render = collision.gameObject.GetComponent<Renderer>();
        render.material.color = Random.ColorHSV();
    }
}
