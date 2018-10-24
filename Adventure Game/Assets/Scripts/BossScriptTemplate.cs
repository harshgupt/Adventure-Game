using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScriptTemplate : MonoBehaviour {

    public BossMovementScript bossMovementScript;

    public Image healthBar;

    float maxHealth = 2f;
    float health;
    float attackTime = 2f;
    float timer = 0;
    float damage = 0f;

    private void Start()
    {
        int totalWaveNo = (LevelScript.level - 1) * 10 + LevelScript.wave;
        maxHealth = Mathf.Ceil(6 * Mathf.Pow(1.15f, totalWaveNo - 1));
        Debug.Log(maxHealth);
        health = maxHealth;
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
            health--;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
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
