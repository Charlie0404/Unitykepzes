using UnityEngine;

class A4 : MonoBehaviour
{
    [SerializeField] int number;           // Bemeneti v�ltoz�

    // Kimeneti v�ltoz�k
    [SerializeField] bool divisibleWith7;  // Oszthat�-e 7-tel
    [SerializeField] bool divisibleWith15; // Oszthat�-e 15-tel
    [SerializeField] bool divisibleWith99; // Oszthat�-e 99-cel

    void OnValidate()
    {
        // Elt�roljuk, hogy a bemenetet osztva 7-tel mekkora marad�kot ad:
        int remainder = number % 7;        // Modulo m�velet
        divisibleWith7 = remainder == 0;  // Ha a marad�k 0, akkor oszthat�

        // A k�vetkez�ket egy-egy sorban oldjuk meg seg�dv�ltoz� n�lk�l:
        divisibleWith15 = number % 15 == 0;
        divisibleWith99 = number % 99 == 0;
    }
}