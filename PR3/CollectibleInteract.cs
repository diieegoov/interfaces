using UnityEngine;

public class CollectibleInteract : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Collectible"))
        {
            Renderer render = other.gameObject.GetComponent<Renderer>();
            render.material.color = Random.ColorHSV();
        }
    }
}
