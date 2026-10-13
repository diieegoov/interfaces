using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Transform target;
    public GameObject obstacle;
    public float speed = 2f;
    public Material newMaterial;

    private bool obstacleReached = false;

    void Update()
    {
        // La esfera se dirige hacia el cilindro
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        // Comprobar si la esfera ha llegado al cubo
        if (!obstacleReached &&
            Vector3.Distance(transform.position, obstacle.transform.position) < 0.8f)
        {
            obstacleReached = true;

            Renderer renderer = obstacle.GetComponent<Renderer>();

            if (renderer != null && newMaterial != null)
            {
                renderer.material = newMaterial;
            }

            Debug.Log("La esfera ha alcanzado el cubo");
        }
    }
}