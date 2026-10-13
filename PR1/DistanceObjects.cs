using UnityEngine;

public class DistanceObjects : MonoBehaviour
{
    void Start()
    {
        // Buscar la esfera mediante su etiqueta
        GameObject esfera = GameObject.FindWithTag("blue_sphere");

        // Buscar el cubo y el cilindro por su nombre
        GameObject cubo = GameObject.Find("Cube");
        GameObject cilindro = GameObject.Find("Cylinder");

        // Calcular la distancia entre el cubo y la esfera
        float distanciaCubo = Vector3.Distance(
            cubo.transform.position,
            esfera.transform.position
        );

        // Calcular la distancia entre el cilindro y la esfera
        float distanciaCilindro = Vector3.Distance(
            cilindro.transform.position,
            esfera.transform.position
        );

        // Mostrar los resultados en la consola
        Debug.Log("Distancia entre el cubo y la esfera: " + distanciaCubo);
        Debug.Log("Distancia entre el cilindro y la esfera: " + distanciaCilindro);
    }
}
