
using UnityEngine;

class Damager : MonoBehaviour
{

    [SerializeField] int damage;
 
    
    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Hit: " + other.name);

        Damageable damageable = other.GetComponent<Damageable>();

        if(damageable != null)
        {
           // Debug.Log("Damage " + damageable.name);
            
            damageable.Damage(damage);

        }


    }
}
