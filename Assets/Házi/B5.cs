using UnityEngine;

class B5 : MonoBehaviour
{
    // Bemeneti v�ltoz�k:
    [SerializeField] float a, b, c; 		 // H�romsz�g oldalai

    // Kimeneti v�ltoz�:
    [SerializeField] bool isPythagorean; // Pitagoraszi sz�mh�rmas-e

    void OnValidate()
    {
        // Pitagorasz-t�tel alkalmaz�sa:
        isPythagorean = a * a + b * b == c * c;
    }
}