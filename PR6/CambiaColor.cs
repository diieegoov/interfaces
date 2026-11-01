using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    public void Seleccionar()
    {
        // Cambia el objeto a verde cuando lo seleccionamos.
        GetComponent<Renderer>().material.color = Color.green;
    }
}