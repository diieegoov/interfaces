using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public Color newColor = Color.red;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Escudo tocado por: " + other.gameObject.name);

        if (other.CompareTag("Tipo1"))
        {
            Debug.Log("Cambiando color de " + other.gameObject.name);

            Renderer[] renderers =
                other.GetComponentsInChildren<Renderer>();

            foreach (Renderer rend in renderers)
            {
                foreach (Material mat in rend.materials)
                {
                    if (mat.HasProperty("_BaseColor"))
                    {
                        mat.SetColor("_BaseColor", newColor);
                    }
                    else if (mat.HasProperty("_Color"))
                    {
                        mat.SetColor("_Color", newColor);
                    }
                }
            }
        }
    }
}