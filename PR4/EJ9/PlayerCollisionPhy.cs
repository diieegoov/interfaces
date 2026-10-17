using System;
using UnityEngine;

public class PlayerCollisionPhy : MonoBehaviour
{
    public static event Action OnType1Collision;
    public static event Action OnType2Collision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tipo1"))
        {
            Debug.Log("Player ha tocado un Footman");
            OnType1Collision?.Invoke();
        }
        else if (other.CompareTag("Tipo2"))
        {
            Debug.Log("Player ha tocado un Lich");
            OnType2Collision?.Invoke();
        }
    }
}