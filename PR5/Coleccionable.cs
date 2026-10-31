using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public bool recogido = false;
    private Transform jugador;
    private Vector3 lugar;

    public void Recoger()
    {
        recogido = true;

        // Oculta el cubo y permite atravesarlo.
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }

    public void Volver(Transform destino, Vector3 posicion)
    {
        if (!recogido || jugador != null) return;

        jugador = destino;
        lugar = posicion;

        // Reaparece para que veamos cómo vuelve.
        GetComponent<Renderer>().enabled = true;
    }

    private void Update()
    {
        if (jugador == null) return;

        // Sigue una posición cercana al jugador.
        transform.position = Vector3.MoveTowards(
            transform.position,
            jugador.TransformPoint(lugar),
            4f * Time.deltaTime);
    }
}