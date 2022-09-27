
using UnityEngine;

class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;

    void Update()
    {

        float rotation = angularSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);


    }
}
