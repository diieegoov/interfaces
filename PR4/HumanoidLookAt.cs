using UnityEngine;

public class HumanoidLookAt : MonoBehaviour
{
    public Transform lookTarget;

    private void OnEnable()
    {
        ProximityEvent.OnPlayerApproach += RotateToTarget;
    }

    private void OnDisable()
    {
        ProximityEvent.OnPlayerApproach -= RotateToTarget;
    }

    private void RotateToTarget()
    {
        if (lookTarget == null)
            return;

        Vector3 direction = lookTarget.position - transform.position;
        direction.y = 0f;

        if (direction.sqrMagnitude > 0.001f)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        Debug.Log(gameObject.name + " se ha orientado");
    }
}