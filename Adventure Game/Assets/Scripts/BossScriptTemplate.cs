using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScriptTemplate : MonoBehaviour {

    float maxHealth = 50f;
    float health;
    public Image healthBar;

    private void Start()
    {
        health = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            health--;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
