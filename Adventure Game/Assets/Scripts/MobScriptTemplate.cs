using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobScriptTemplate : MonoBehaviour {

    public MobMovementScript mobMovementScript;

    public Image healthBar;

    float maxHealth = 1f;
    float health;
    float attackTime = 1f;
    float timer = 0;
    float damage = 1f;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if (mobMovementScript.reachedEnd)
        {
            timer += Time.deltaTime;
            if (timer >= attackTime)
            {
                timer = 0;
                AttackPlayer();
            }
        }
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

    public void AttackPlayer()
    {
        PlayerData.playerHealth -= damage;
        Debug.Log(PlayerData.playerHealth);
    }
}
