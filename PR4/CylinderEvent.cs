using System;
using UnityEngine;

public class CylinderEvent : MonoBehaviour
{

    public static event Action OnCubeCollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player"))
          {
              Debug.Log("El cubo ha tocado el cilindro");
              // invoke ejecuta todas las funciones susicritas al evento
              OnCubeCollision?.Invoke();
          }
    }
}
