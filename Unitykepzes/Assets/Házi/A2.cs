using UnityEngine;

class A2 : MonoBehaviour
{
    // Bemeneti v�ltoz�k
    [SerializeField] int a;
    [SerializeField, Min(1)] int b = 1; // Kezd�- �s minimum �rt�ket adhatunk, 
                                        // hogy elker�lj�k a null�val val� oszt�st

    

    [SerializeField] int quotient;      // H�nyados
    [SerializeField] int remainder;     // Marad�k


     
    // Az OnValidate met�dus lefut automatikusan,
    // amikor b�rmit v�ltoztatunk a komponens inspector fel�let�n.
    void OnValidate()
    {
        
        quotient = a / b;
        remainder = a % b;

      
    }

    
}