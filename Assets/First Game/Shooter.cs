
using UnityEngine;

public class Shooter : MonoBehaviour
{

    enum ShootingPattern 
    {
       Random, Sequence 
   
    }


    [SerializeField] GameObject [] projectilePrototypes;
    [SerializeField] float speed;

    [SerializeField] ShootingPattern pattern; // még egy lehetõséget felvenni és valamilyen billentyûvel tudjak lõni , 1es bullet egyes gomb de ugyanúgy space el fire
    [SerializeField] KeyCode[] keys; // pl 
    


    int count = 0; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject proto;

            if (pattern == ShootingPattern.Random)

            {


                int randomNum = Random.Range(0, projectilePrototypes.Length);
                proto = projectilePrototypes[randomNum];
            }

            else
            {
                int index = count % projectilePrototypes.Length;

                proto = projectilePrototypes[index];
            }


                                         
                      
            
            GameObject projectile = Instantiate(proto);

            projectile.transform.position = transform.position;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            Vector3 direction = transform.forward; //transform forward , lokális irányt globálisra kérjük le

            /* Vector3 v = transform.TransformVector(Vector3.up);  // sajátból világ koordinátába alakítja
             Vector3 v2 = transform.InverseTransformVector(v);     // transform.TransformPoint // globálbol lokális. mindent tart.
             */

            direction.Normalize();

            rb.velocity = direction * speed;
            count++;
        }
    }
}
