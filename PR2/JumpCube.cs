using UnityEngine;

public class JumpCube : MonoBehaviour
{
    public Vector3 desplazamiento;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move()
    {
        transform.position += desplazamiento;
    }
}
