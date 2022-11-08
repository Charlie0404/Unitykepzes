
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

    [SerializeField] ShootingPattern pattern; // még egy lehetõséget felvenni és valamilyen billentyûvel tudjak lõni , 1es bullet egyes gomb de ugyanúgy space el fire
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

        Vector3 direction = transform.forward; //transform forward , lokális irányt globálisra kérjük le

        /* Vector3 v = transform.TransformVector(Vector3.up);  // sajátból világ koordinátába alakítja
         Vector3 v2 = transform.InverseTransformVector(v);     // transform.TransformPoint // globálbol lokális. mindent tart.
         */

        direction.Normalize();

        rb.velocity = direction * speed;
        count++;
    }
}
