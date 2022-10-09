using UnityEngine;

class C3 : MonoBehaviour
{
    [SerializeField] int number;     // Bemeneti változó
    [SerializeField] string text;    // Kimeneti változó

    void OnValidate()
    {
        text = "";               // Üres string-gel kezdünk

        for (int i = 1; i <= number; i++)
        {
            text = text + i;

            if (i != number)    // az utolsó szám kivételével
                text += ", ";
                                



        }



    }
}