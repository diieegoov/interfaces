using UnityEngine;

public class Marcador : MonoBehaviour
{
    public JumpCube cube1;
    public JumpCube cube2;
    public JumpCube cube3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            cube1.Move();
            cube2.Move();
            cube3.Move();
        }
    }
}
