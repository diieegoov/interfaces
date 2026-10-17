using UnityEngine;

public class ShieldCollisionPhy : MonoBehaviour
{
    public Color newColor = Color.red;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Tipo1"))
            return;

        Debug.Log(other.name + " ha tocado Escudo2");

        Renderer[] renderers =
            other.GetComponentsInChildren<Renderer>();

        foreach (Renderer rend in renderers)
        {
            foreach (Material mat in rend.materials)
            {
                if (mat.HasProperty("_BaseColor"))
                    mat.SetColor("_BaseColor", newColor);
                else if (mat.HasProperty("_Color"))
                    mat.SetColor("_Color", newColor);
            }
        }
    }
}