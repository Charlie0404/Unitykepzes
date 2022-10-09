using UnityEngine;

class A4 : MonoBehaviour
{
    [SerializeField] int number;           // Bemeneti változó

    // Kimeneti változók
    [SerializeField] bool divisibleWith7;  // Osztható-e 7-tel
    [SerializeField] bool divisibleWith15; // Osztható-e 15-tel
    [SerializeField] bool divisibleWith99; // Osztható-e 99-cel

    void OnValidate()
    {
        // Eltároljuk, hogy a bemenetet osztva 7-tel mekkora maradékot ad:
        int remainder = number % 7;        // Modulo mûvelet
        divisibleWith7 = remainder == 0;  // Ha a maradék 0, akkor osztható

        // A következõket egy-egy sorban oldjuk meg segédváltozó nélkül:
        divisibleWith15 = number % 15 == 0;
        divisibleWith99 = number % 99 == 0;
    }
}