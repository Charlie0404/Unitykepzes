
using UnityEngine;

class Explo : MonoBehaviour
{


    [SerializeField] float maxForce;
    [SerializeField] float range;
    [SerializeField] Rigidbody[] rigidbodies;
    [SerializeField] float upward;
    [SerializeField] LayerMask raycastlayers;
    [SerializeField] new ParticleSystem particleSystem;

    

    Vector3 lastRayHit;



    void Start()
    {

        rigidbodies = FindObjectsOfType<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))


        {
            Camera cam = Camera.main;

            Vector3 mousePos = Input.mousePosition;

            Ray ray = cam.ScreenPointToRay(mousePos); // sugárkeresés

            // Ray otherRay = new Ray(transform.position, transform.forward);



            bool doesHit = Physics.Raycast(ray, out RaycastHit hit, 100, raycastlayers); // sugárvetés


            if (doesHit)
            {

                lastRayHit = hit.point;
                transform.position = lastRayHit;
                particleSystem.Play();
                Debug.Log(hit.collider.name + "    " + hit.point);
                ExplodeAll(lastRayHit); 


            }

        }


    }

    void ExplodeAll(Vector3 position)
    {
        foreach (Rigidbody rb in rigidbodies)
        {

            rb.AddExplosionForce(maxForce, position, range, upward, ForceMode.Impulse);

        }



    }

    void ExplodeOne(Vector3 position)
    {
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            Rigidbody rb = rigidbodies[i];

            Vector3 distanceVect = rb.transform.position - position;
            float distance = distanceVect.magnitude;
            Vector3 direction = distanceVect.normalized;

            if (distance < range)
            {
                float force = maxForce * (range - distance) / range;

                rb.AddForce(force * direction, ForceMode.Impulse);
            }






        }

    }




    private void OnDrawGizmos()
    {

        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(lastRayHit, 0.2f);


    }



}
