using System;
using UnityEngine;

public class ProximityEvent : MonoBehaviour
{
    public Transform player;
    public float detectionDistance = 3f;

    public static event Action OnPlayerApproach;

    private bool activated = false;

    private void Update()
    {
        if (player == null || activated)
            return;

        float distance = Vector3.Distance(
            transform.position,
            player.position
        );

        if (distance <= detectionDistance)
        {
            activated = true;

            Debug.Log("El cubo se ha acercado al objeto");

            OnPlayerApproach?.Invoke();
        }
    }
}