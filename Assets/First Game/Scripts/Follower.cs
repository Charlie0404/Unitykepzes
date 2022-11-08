
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve distance;

    [SerializeField] new Rigidbody rigidbody;


    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody>();

    }




    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfpoint = transform.position;

        /*
        Vector3 velocity = targetPoint - selfpoint;
        velocity.Normalize();
        velocity *= speed;
        velocity *= Time.deltaTime;
        float stepDistance = velocity.magnitude;
        float targetDistance = Vector3.Distance(targetPoint, selfpoint);

        if (targetDistance < stepDistance)
        {
            velocity.Normalize();
            velocity *= targetDistance;

        }

        transform.position += velocity;

        */


        Vector3 direction = targetPoint - selfpoint;
        direction.Normalize();

        rigidbody.velocity = direction * speed;



        /*
        float maxstep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(selfpoint, targetPoint, maxstep);    // ezzel mûködött
        */

        if (targetPoint != selfpoint)


        {


            transform.rotation = Quaternion.LookRotation(targetPoint - selfpoint);

        }




    }
}
