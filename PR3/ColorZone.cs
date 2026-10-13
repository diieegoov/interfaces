using UnityEngine;

public class ColorZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Renderer render = other.GetComponent<Renderer>();
            render.material.color = Color.red;
            Debug.Log("El jugador ha entrado en la zona");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Renderer renderer = other.GetComponent<Renderer>();
            renderer.material.color = Color.white;
            Debug.Log("El jugador ha salido de la zona");
        }
    }
}
