
using UnityEngine;

public class Shooter : MonoBehaviour
{

    enum ShootingPattern 
    {
       Random, Sequence 
   
    }


    [SerializeField] GameObject [] projectilePrototypes;
    [SerializeField] float speed;

    [SerializeField] ShootingPattern pattern; // m�g egy lehet�s�get felvenni �s valamilyen billenty�vel tudjak l�ni , 1es bullet egyes gomb de ugyan�gy space el fire
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

            Vector3 direction = transform.forward; //transform forward , lok�lis ir�nyt glob�lisra k�rj�k le

            /* Vector3 v = transform.TransformVector(Vector3.up);  // saj�tb�l vil�g koordin�t�ba alak�tja
             Vector3 v2 = transform.InverseTransformVector(v);     // transform.TransformPoint // glob�lbol lok�lis. mindent tart.
             */

            direction.Normalize();

            rb.velocity = direction * speed;
            count++;
        }
    }
}
