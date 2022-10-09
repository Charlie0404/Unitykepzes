using UnityEngine;

class A3 : MonoBehaviour
{

    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [SerializeField] int d;
    [SerializeField] int e;

    [SerializeField] int összeg;

    [SerializeField] float átlag;





    void OnValidate()
    {

        összeg = a + b + c + d + e;
        átlag = összeg / 5f;

    }
}
