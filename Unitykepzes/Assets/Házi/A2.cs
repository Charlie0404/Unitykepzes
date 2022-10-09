using UnityEngine;

class A2 : MonoBehaviour
{
    // Bemeneti változók
    [SerializeField] int a;
    [SerializeField, Min(1)] int b = 1; // Kezdõ- és minimum értéket adhatunk, 
                                        // hogy elkerüljük a nullával való osztást

    

    [SerializeField] int quotient;      // Hányados
    [SerializeField] int remainder;     // Maradék


     
    // Az OnValidate metódus lefut automatikusan,
    // amikor bármit változtatunk a komponens inspector felületén.
    void OnValidate()
    {
        
        quotient = a / b;
        remainder = a % b;

      
    }

    
}