using UnityEngine;

class C3 : MonoBehaviour
{
    [SerializeField] int number;     // Bemeneti v�ltoz�
    [SerializeField] string text;    // Kimeneti v�ltoz�

    void OnValidate()
    {
        text = "";               // �res string-gel kezd�nk

        for (int i = 1; i <= number; i++)
        {
            text = text + i;

            if (i != number)    // az utols� sz�m kiv�tel�vel
                text += ", ";
                                



        }



    }
}