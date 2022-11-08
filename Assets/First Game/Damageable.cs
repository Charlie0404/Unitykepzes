
using UnityEngine;
using TMPro;
using System;
using System.Collections;

class Damageable : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] TMP_Text healthtext;

    [SerializeField] Behaviour behavior;   // Lehetne monobehavior, így bármit kikapcsolhatunk
    [SerializeField] float invincibilityFrames = 1;


    bool isInvicible = false;



   
    void Start()
    {
        updatetext();
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public void Damage(int Damage)
    {
        if (isInvicible)
        {

            return;


        }

        health -= Damage;


        StartCoroutine(InvincibilityCoroutine());


        
        // isInvicible = true;

        if (health < 0)
            health = 0;

        if (health == 0)
            behavior.enabled = false;

        updatetext();

    }


    IEnumerator InvincibilityCoroutine()

    {
        isInvicible = true;
        yield return new WaitForSeconds(invincibilityFrames);
        isInvicible = false;

    }

    void updatetext()
    {
        if (healthtext != null)
            healthtext.text = "Health: " + health;
    }
}
