using UnityEngine;

class A3 : MonoBehaviour
{

    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [SerializeField] int d;
    [SerializeField] int e;

    [SerializeField] int �sszeg;

    [SerializeField] float �tlag;





    void OnValidate()
    {

        �sszeg = a + b + c + d + e;
        �tlag = �sszeg / 5f;

    }
}
