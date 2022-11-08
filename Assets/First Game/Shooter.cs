
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    enum ShootingPattern
    {

        Random, Sequence, Keyboard

    }


    [SerializeField] GameObject[] projectilePrototypes;
    [SerializeField] float speed;

    [SerializeField] ShootingPattern pattern; // m�g egy lehet�s�get felvenni �s valamilyen billenty�vel tudjak l�ni , 1es bullet egyes gomb de ugyan�gy space el fire
    [SerializeField] List<KeyCode> keys; // pl 
    [SerializeField] float destructionTime;

    float startTime;


    int count = 0;
    int bulletIndex = 0;





    void Update()
    {
        BulletSelect();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void BulletSelect()
    {
        for (int i = 0; i < keys.Count; i++)
        {
            KeyCode kc = keys[i];

            if (Input.GetKeyDown(kc))
            {
                bulletIndex = i;

            }


        }

    }

    private void Shoot()
    {
        GameObject proto;
        if (pattern == ShootingPattern.Random)

        {


            int randomNum = Random.Range(0, projectilePrototypes.Length);
            proto = projectilePrototypes[randomNum];
        }

        else if (pattern == ShootingPattern.Sequence)
        {
            int index = count % projectilePrototypes.Length;

            proto = projectilePrototypes[index];
        }
        else


        {
            int safeIndex = Mathf.Clamp(bulletIndex, 0, projectilePrototypes.Length - 1);
            proto = projectilePrototypes[safeIndex];

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
