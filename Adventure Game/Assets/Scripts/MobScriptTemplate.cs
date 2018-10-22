using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobScriptTemplate : MonoBehaviour {

    float maxHealth = 1f;
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
            if(health <= 0)
            {
                MobSpawner.mobsOnScreen--;
                if(MobSpawner.mobsOnScreen == 0)
                {
                    LevelScript.wave++;
                }
                Destroy(gameObject);
            }
        }
    }
}
