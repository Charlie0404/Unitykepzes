using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Color col;
    [SerializeField] float speed;

    [SerializeField] bool toA = false; // ez is field,elt�rol�sra

    void OnValidate()
    {

        transform.position = (a + b) / 2f; // nem kell felt�tlen az f

    }


    void Update() //J�t�kban is m�k�dj�n
    {
        Vector3 target;
        if (toA)
            target = a;
        else
            target = b;
        

        if(target == transform.position)
        {

            toA = !toA;

        }



        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);


    }


    void OnDrawGizmos()  //Selected is van
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(a, 0.2f);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(b, 0.2f);
        Gizmos.color = new Color(1, 0, 1, 0.75f); // 0.5f is lehet, RGB A, + a negyedik az alpha, �tmenet sz�n, �tl�tszhat�s�g
        Gizmos.DrawLine(a, b);
    }
}
