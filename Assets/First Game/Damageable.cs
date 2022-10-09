
using UnityEngine;
using TMPro;
using System;

class Damageable : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] TMP_Text healthtext;

    [SerializeField] Behaviour behavior;   // Lehetne monobehavior, így bármit kikapcsolhatunk

    internal bool IsAlive()
    {
        return health > 0;
    }

    void Start()
    {
        updatetext();
    }


    public void Damage(int Damage)
    {
        health -= Damage;
        if (health < 0)
            health = 0;

        if (health == 0)
            behavior.enabled = false;

        updatetext();

    }

    void updatetext()
    {
        if (healthtext != null)
            healthtext.text = "Health: " + health;
    }
}
