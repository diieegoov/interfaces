using UnityEngine;

public class HumanoidTeleport : MonoBehaviour
{
    public Transform targetShield;

    private void OnEnable()
    {
        ProximityEvent.OnPlayerApproach += Teleport;
    }

    private void OnDisable()
    {
        ProximityEvent.OnPlayerApproach -= Teleport;
    }

    private void Teleport()
    {
        if (targetShield == null)
            return;

        transform.position = targetShield.position;

        Debug.Log(gameObject.name + " se ha teletransportado");
    }
}