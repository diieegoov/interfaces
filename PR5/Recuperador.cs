using UnityEngine;

public class Recuperador : MonoBehaviour
{
    public void Recuperar(Transform jugador)
    {
        // Encuentra los cubos de la escena.
        Coleccionable[] cubos = FindObjectsByType<Coleccionable>();

        float lado = -0.6f;

        foreach (Coleccionable cubo in cubos)
        {
            if (!cubo.recogido) continue;

            // Un cubo vuelve a la izquierda y el otro a la derecha.
            cubo.Volver(jugador, new Vector3(lado, 1f, 0.8f));
            lado += 1.2f;
        }
    }
}