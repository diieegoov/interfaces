using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action OnType1Collision;
    public static event Action OnType2Collision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tipo1"))
        {
            Debug.Log("El cubo ha tocado un humanoide Tipo1");
            OnType1Collision?.Invoke();
        }
        else if (other.CompareTag("Tipo2"))
        {
            Debug.Log("El cubo ha tocado un humanoide Tipo2");
            OnType2Collision?.Invoke();
        }
    }
}