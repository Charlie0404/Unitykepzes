
using UnityEngine;

class MethodPractice : MonoBehaviour
{

    [SerializeField]

    void Start()
    {
        Logsqr(1, 5);
        Logsqr(10, 20);
        Logsqr(3, 7);

    }

    void Logsqr(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Debug.Log(i * i);
        }

        float f1 = Power(0.2f, 5);
    }

    float Power(float baseNumber, int exponent)
    {
        float number = 1;

        for (int i = 0; i < exponent; i++)
        {
            number = number * baseNumber;

        }
        return number;

    }

    float Minimum(float a, float b)
    {
        float result;
        if (a < b)
        {
            result = a;
        }
        else
        {
            result = b;
        }
        return result;
    }

    float Maximum(float a, float b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    float Maximum(float a, float b, float c)
    {

        if (a > b && a > c)
        {
            return a;
        }

        if (b > c)
        {
            return b;
        }

        return c;

    }

   /* float Round(float num)
    {



    }
   */

}

