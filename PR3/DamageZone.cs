using UnityEngine;

public class DamageZone : MonoBehaviour
{

    public int damage = 0;
    public int damage_take = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            damage += damage_take;
            Debug.Log("Daño total hecho: " + damage);
        }
    }
}
