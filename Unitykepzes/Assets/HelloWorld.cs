
using UnityEngine;

class HelloWorld : MonoBehaviour
{
    void Start()
    {
        //Bemutatkozás
        Debug.Log("Hello World");
        Debug.Log("I'm " + name);


        int myFirstVariable;   //Egész számok
        myFirstVariable = 56;
        myFirstVariable = 47;


        int a, b, c;

        a = 3;
        b = 7;
        c = a + b;
        Debug.Log(c);
        c = 145;
        Debug.Log(c);

        int d = a - b;
        int e = a * b;
        int f = a / b;
        Debug.Log(f);

        float myFirstFloat = 2.67f;
        float mySecondFloat = 4;
        float ratio = myFirstFloat / mySecondFloat; //Változó
        Debug.Log(ratio);

        string myFirstString = "Hello";
        string mySecondString = "World";


        string sss = myFirstString + mySecondString;

        Debug.Log(sss);



        float fff = (float)a / b;
        Debug.Log(fff);


        //Casting

        float f1 = 1;


        string s1 = $"Hello world,{ratio} ";

        int age = 31;
        float height = 1.84f;
        string myname = "Karesz";

        string introduction = $"My name is {myname},I'm {height} m height and {age} years old. ";

        Debug.Log(introduction);

        // Moduló

        int m = 22 % 7;   // 1 

        float mf = 12.34f % 5; // 2.34f

        bool bb1 = true;
        bool bb2 = false;

        bb2 = true;




    }
}
