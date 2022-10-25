
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

            Vector3 direction = transform.forward; //transform forward , lok�lis ir�nyt glob�lisra k�rj�k le

            /* Vector3 v = transform.TransformVector(Vector3.up);  // saj�tb�l vil�g koordin�t�ba alak�tja
             Vector3 v2 = transform.InverseTransformVector(v);     // transform.TransformPoint // glob�lbol lok�lis. mindent tart.
             */
            direction.Normalize();

            rb.velocity = direction * speed;
        
        }
    }
}
