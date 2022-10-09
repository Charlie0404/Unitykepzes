
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve distance;


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

        float maxstep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(selfpoint, targetPoint, maxstep);


        if (targetPoint != selfpoint)


        {


            transform.rotation = Quaternion.LookRotation(targetPoint - selfpoint);

        }




    }
}
