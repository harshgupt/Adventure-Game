using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScriptTemplate : MonoBehaviour {

    public BossMovementScript bossMovementScript;

    public Image healthBar;

    double maxHealth = 2f;
    double health;
    float attackTime = 2f;
    float timer = 0;
    double damage = 0f;
    double coinsDropped;

    private void Start()
    {
        int totalWaveNo = (LevelScript.level - 1) * 10 + LevelScript.wave;
        maxHealth = Mathf.Ceil(10 * Mathf.Pow(1.15f, totalWaveNo - 1));
        damage = Mathf.Ceil(10 * Mathf.Pow(1.14f, totalWaveNo - 1));
        health = maxHealth;
        coinsDropped = Mathf.Ceil(400f * Mathf.Pow(1.15f, totalWaveNo - 1));
    }

    private void Update()
    {
        if (bossMovementScript.reachedEnd)
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
            health-= PlayerData.playerDamage;
            healthBar.fillAmount = (float)(health / maxHealth);
            if (health <= 0)
            {
                PlayerData.coins += coinsDropped;
                LevelScript.wave = 1;
                LevelScript.level++;
                MobSpawner.bossOnScreen = 0;
                Destroy(gameObject);
            }
        }
    }

    public void AttackPlayer()
    {
        PlayerData.playerHealth -= damage;
    }
}
