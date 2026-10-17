using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;

    private bool moving = false;
    private Vector3 destination;

    private void OnEnable()
    {
        CylinderEvent.OnCubeCollision += StartMoving;
    }

    private void OnDisable()
    {
        CylinderEvent.OnCubeCollision -= StartMoving;
    }

    private void StartMoving()
    {
        if (target == null)
            return;

        destination = target.position;
        moving = true;

        Debug.Log(gameObject.name + " comienza a moverse");
    }

    private void Update()
    {
        if (!moving)
            return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            destination,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, destination) < 0.01f)
        {
            moving = false;
        }
    }
}