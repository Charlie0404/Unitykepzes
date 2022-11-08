using TMPro;
using UnityEngine;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int collectedValue;

    void Start()
    {
        FreshTest();
    }

    void OnTriggerEnter(Collider other)
    {
        Collectable c = other.GetComponent<Collectable>();
        if (c != null)
        {
            collectedValue += c.value;
            c.TeleportRandom();
            FreshTest();
        }
    }

    void FreshTest()
    {
        if (scoreText != null)
            scoreText.text = $"Score: {collectedValue}";
    }
}