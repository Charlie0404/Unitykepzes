
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
    int startHealth;



    void Start()
    {
        startHealth = health;
        health = PlayerPrefs.GetInt("health",health);
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

        PlayerPrefs.SetInt("health", health); //Élet mentés

        StartCoroutine(InvincibilityCoroutine());
        


        // isInvicible = true;

        if (health < 0)
            health = 0;

        if (health == 0)
        {
            behavior.enabled = false;
            PlayerPrefs.SetInt("health", startHealth);
        }
        updatetext();

    }


    IEnumerator InvincibilityCoroutine()

    {
        const float flickTime = 0.02f;


        isInvicible = true;



        bool visible = false;
        for (int i = 0; i < invincibilityFrames / flickTime; i++)
        {
            SetVisibility(false);
            visible = !visible;         // "!" Negán, kicseréli az értéket true-ról false-ra, vagy false rol true ra
            yield return new WaitForSeconds(flickTime);
        }




        SetVisibility(true);
        isInvicible = false;
    }

    void SetVisibility(bool isVisible)                  // villogás vagy eltûnés sebzésre
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();

        foreach (var renderer in renderers)
        {
            renderer.enabled = isVisible;
        }


    }

    void updatetext()
    {
        if (healthtext != null)
            healthtext.text = "Health: " + health;
    }
}
