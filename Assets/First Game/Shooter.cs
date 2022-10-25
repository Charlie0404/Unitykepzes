
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] float speed;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject projectile = Instantiate(projectilePrototype);

            projectile.transform.position = transform.position;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            Vector3 direction = transform.forward; //transform forward , lokális irányt globálisra kérjük le

            /* Vector3 v = transform.TransformVector(Vector3.up);  // sajátból világ koordinátába alakítja
             Vector3 v2 = transform.InverseTransformVector(v);     // transform.TransformPoint // globálbol lokális. mindent tart.
             */
            direction.Normalize();

            rb.velocity = direction * speed;
        
        }
    }
}
