using UnityEngine;
using System;
using Random = UnityEngine.Random;

class Collectable : MonoBehaviour
{
    [SerializeField] Bounds bounds;

    public int value = 1;

    public void TeleportRandom()
    {
        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomY = Random.Range(bounds.min.y, bounds.max.y);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        transform.position = new Vector3(randomX, randomY, randomZ);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}