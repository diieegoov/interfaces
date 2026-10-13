using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed;
    private float result;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            result = Input.GetAxis("Vertical") * speed;
            Debug.Log("Arriba: " + speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            result = Input.GetAxis("Vertical") * speed;
            Debug.Log("Abajo: " + speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            result = Input.GetAxis("Horizontal") * speed;
            Debug.Log("Izquierda: " + result);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            result = Input.GetAxis("Horizontal") * speed;
            Debug.Log("Derecha: " + result);
        }
    }
}
