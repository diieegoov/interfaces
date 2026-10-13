using UnityEngine;

public class ChangeColors: MonoBehaviour
{
    public int frames_wait = 120;
    private Color color;
    private int contador_frames = 0;
    private Renderer rend;

    void Start() {
        rend = GetComponent<Renderer>();
        color = new Color(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f), 
            Random.Range(0.0f, 1.0f)
        );
        rend.material.color = color;
    }

    void Update() {
        contador_frames++;

        if (contador_frames >= frames_wait)
        {
            int posicion = Random.Range(0, 3);

            if (posicion == 0)
            {
                color.r = Random.Range(0.0f, 1.0f);
            }
            else if (posicion == 1)
            {
                color.g = Random.Range(0.0f, 1.0f);
            }
            else
            {
                color.b = Random.Range(0.0f, 1.0f);
            }

            rend.material.color = color;
            contador_frames = 0;
        }
    }
}

