using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobScriptTemplate : MonoBehaviour {

    public MobMovementScript mobMovementScript;

    public Image healthBar;

    double maxHealth = 1f;
    double health;
    float attackTime = 1f;
    float timer = 0;
    double damage = 0f;
    double coinsDropped;

    private void Start()
    {
        int totalWaveNo = (LevelScript.level - 1) * 10 + LevelScript.wave;
        Debug.Log(totalWaveNo);
        maxHealth = Mathf.Ceil(2 * Mathf.Pow(1.15f, totalWaveNo - 1));
        damage = Mathf.Ceil(Mathf.Pow(1.15f, totalWaveNo - 1));
        health = maxHealth;
        coinsDropped = Mathf.Ceil(80f * Mathf.Pow(1.15f, totalWaveNo - 1));
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
            health -= PlayerData.playerDamage;
            healthBar.fillAmount = (float)(health / maxHealth);
            if(health <= 0)
            {
                MobSpawner.mobsOnScreen--;
                PlayerData.coins += coinsDropped;
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
    }
}
