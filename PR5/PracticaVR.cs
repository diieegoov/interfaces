using UnityEngine;

#if UNITY_EDITOR
using UnityEngine.InputSystem;
#endif

public class PracticaVR : MonoBehaviour
{
    public Camera camara;

    private CharacterController cuerpo;
    private Collider anterior;
    private float tiempo;

    private void Start()
    {
        cuerpo = GetComponent<CharacterController>();

#if UNITY_EDITOR
        // Permite controlar la cámara con el ratón en el editor.
        foreach (Behaviour componente in camara.GetComponents<Behaviour>())
        {
            if (componente.GetType().Name == "TrackedPoseDriver")
                componente.enabled = false;
        }
#endif
    }

    private void Update()
    {
#if UNITY_EDITOR
        // Botón derecho y ratón para mirar alrededor.
        if (Mouse.current != null &&
            Mouse.current.rightButton.isPressed)
        {
            Vector2 raton = Mouse.current.delta.ReadValue();
            transform.Rotate(0f, raton.x * 0.1f, 0f);
            camara.transform.Rotate(-raton.y * 0.1f, 0f, 0f);
        }
#endif

        // Mirar hacia abajo hace avanzar; mirar al frente detiene.
        Vector3 movimiento = Vector3.zero;

        if (camara.transform.forward.y < -0.45f)
        {
            movimiento = camara.transform.forward;
            movimiento.y = 0f;
            movimiento = movimiento.normalized * 1.5f;
        }

        movimiento.y = -2f; // Mantiene al jugador sobre el terreno.
        cuerpo.Move(movimiento * Time.deltaTime);

        // Detecta el primer objeto que hay delante de la cámara.
        Collider actual = null;

        if (Physics.Raycast(camara.transform.position,
            camara.transform.forward, out RaycastHit impacto, 6f))
        {
            actual = impacto.collider;
        }

        // Al cambiar de objeto, la espera empieza de nuevo.
        if (actual != anterior)
        {
            tiempo = 0f;
            anterior = actual;
        }

        if (actual == null) return;

        tiempo += Time.deltaTime;
        if (tiempo < 1.2f) return;

        Coleccionable cubo = actual.GetComponent<Coleccionable>();
        Recuperador esfera = actual.GetComponent<Recuperador>();

        // Para recoger un cubo hay que estar a menos de 3 metros.
        if (cubo != null &&
            Vector3.Distance(camara.transform.position,
                cubo.transform.position) < 3f)
        {
            cubo.Recoger();
        }

        if (esfera != null)
            esfera.Recuperar(transform);
    }
}