
using UnityEngine;

class ControlStructuresPractices : MonoBehaviour
{
    [SerializeField] int number;

    [SerializeField] string pairity;
    [SerializeField] string positivity;

    void OnValidate()
    {
        pairity = "";

        bool isEven = number % 2 == 0;
        if (isEven)
        {
            pairity = "P�ros";

        }
        else
        {
            pairity = "P�ratlan";

        }

        if (number < 0)
        {
            positivity = "Negat�v";

        }
        else if (number > 0)
        {
            positivity = "Pozit�v";


        }
        else
        {

            positivity = "Nulla";


        }


    }
    void Start()
    {
        int i = 1;
        while (i <= 10)
        {
            Debug.Log(i * i);

            i++;




        }

        for (int j = 10; j >= 1; j--)
        {
            Debug.Log(j); 
        }



    }


}




