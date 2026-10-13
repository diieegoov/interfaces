using UnityEngine;

public class VectorConsole : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 vector_first;
    public Vector3 vector_second;
    public float magnitud_first;
    public float magnitud_second;
    public float angulo;
    public float distancia;
    public string vectorMayorAltura;
    
    void Start()
    {
        magnitud_first = vector_first.magnitude;
        magnitud_second = vector_second.magnitude;
        angulo = Vector3.Angle(vector_first, vector_second);
        distancia = Vector3.Distance(vector_first, vector_second);
        
        Debug.Log("Magnitud Vector 1: " + magnitud_first);
        Debug.Log("Magnitud Vector 2: " + magnitud_second);
        Debug.Log("Ángulo entre Vector 1 y Vector 2: " + angulo);
        Debug.Log("Ángulo entre Vector 1 y Vector 2: " + Vector3.Distance(vector_first, vector_second));
        if (vector_first.y > vector_second.y)
        {
            vectorMayorAltura = "Vector 1";
            Debug.Log("Vector 1 está más alto");
        }
        else if (vector_first.y < vector_second.y)
        {
            vectorMayorAltura = "Vector 2";
            Debug.Log("Vector 2 está más alto");
        }
        else
        {
            vectorMayorAltura = "Ambos";
            Debug.Log("Ambos vectores están a la misma altura");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
