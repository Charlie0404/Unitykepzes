
using UnityEngine;

public class autodestroyer : MonoBehaviour
{

    [SerializeField] float destructionTime;

    float startTime;


    void Start()
    {
        startTime = Time.time;
    }


    void Update()
    {
        float currenttime = Time.time;


        if (startTime + destructionTime < currenttime)
        {
            Destroy(gameObject);
        }


    }
}
