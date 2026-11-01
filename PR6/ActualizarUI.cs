using UnityEngine;
using TMPro;

public class ActualizarUI : MonoBehaviour
{
    public TMP_Text texto;

    public void Agarrar()
    {
        // Mensaje que aparece al coger el objeto.
        texto.text = "Objeto agarrado";
    }

    public void Soltar()
    {
        // Mensaje que aparece al soltarlo.
        texto.text = "Objeto soltado";
    }
}