using UnityEngine;

public class HumanoidMovement : MonoBehaviour
{
    public Transform shieldType1;
    public Transform[] shieldsType2;

    public float speed = 2f;

    private Transform target;
    private bool moving = false;

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
        moving = target != null;
    }

    private void MoveToShield2()
    {
        if (shieldsType2 == null || shieldsType2.Length == 0)
            return;

        // Elegimos un escudo Tipo2 aleatoriamente
        target = shieldsType2[Random.Range(0, shieldsType2.Length)];
        moving = target != null;
    }

    private void Update()
    {
        if (!moving || target == null)
            return;

        Vector3 destination = target.position;
        destination.y = transform.position.y;

        transform.position = Vector3.MoveTowards(
            transform.position,
            destination,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, destination) < 0.1f)
        {
            moving = false;
        }
    }
}