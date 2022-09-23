using UnityEngine;

class B5 : MonoBehaviour
{
    // Bemeneti változók:
    [SerializeField] float a, b, c; 		 // Háromszög oldalai

    // Kimeneti változó:
    [SerializeField] bool isPythagorean; // Pitagoraszi számhármas-e

    void OnValidate()
    {
        // Pitagorasz-tétel alkalmazása:
        isPythagorean = a * a + b * b == c * c;
    }
}