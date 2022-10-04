
using UnityEngine;

public class Plargyakorlás : MonoBehaviour
{

    [SerializeField] Color colorA, colorB;
    [SerializeField] Vector3 posA, posB;
    [SerializeField] float t;



    [SerializeField] Color lerpcolor;
    [SerializeField] Vector3 lerpos;


    void OnValidate()
    {
        lerpcolor = Color.Lerp(colorA, colorB, t);
        lerpos = Vector3.Lerp(posA, posB, t);

    }
}
