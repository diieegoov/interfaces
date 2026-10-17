using UnityEngine;

public class HumanoidMovementPhy : MonoBehaviour
{
    public Transform shieldType1;
    public Transform shieldType2;

    public float speed = 2f;
    public float rotationSpeed = 5f;

    private Rigidbody rb;
    private Transform target;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        PlayerCollision.OnType2Collision += MoveToShield1;
        PlayerCollision.OnType1Collision += MoveToShield2;
    }

    private void OnDisable()
    {
        PlayerCollision.OnType2Collision -= MoveToShield1;
        PlayerCollision.OnType1Collision -= MoveToShield2;
    }

    private void MoveToShield1()
    {
        target = shieldType1;
    }

    private void MoveToShield2()
    {
        target = shieldType2;
    }

    private void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 destination = target.position;
        destination.y = rb.position.y;

        Vector3 direction = destination - rb.position;

        if (direction.magnitude < 0.1f)
        {
            target = null;
            return;
        }

        Vector3 nextPosition = Vector3.MoveTowards(
            rb.position,
            destination,
            speed * Time.fixedDeltaTime
        );

        rb.MovePosition(nextPosition);

        Quaternion rotation = Quaternion.LookRotation(direction);

        rb.MoveRotation(
            Quaternion.Slerp(
                rb.rotation,
                rotation,
                rotationSpeed * Time.fixedDeltaTime
            )
        );
    }
}