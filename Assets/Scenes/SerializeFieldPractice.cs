
using UnityEngine;

class SerializeFieldPractice : MonoBehaviour
{
    [SerializeField] int number1, number2;
    [SerializeField] int sum;
    [SerializeField] int difference;
    [SerializeField] int product;
    [SerializeField] int rate;

    void Start()
    {
        int i = 4;
        Debug.Log(i);

    }
    void OnValidate()
    {
        sum = number1 + number2;
        difference = number1 - number2;
        product = number1 * number2;
        

    }
}
