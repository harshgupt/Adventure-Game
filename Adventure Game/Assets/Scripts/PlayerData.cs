using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour {

    public Image playerHealthBar;

    public static double playerMaxHealth = 96;
    public static double coins;
    public static double playerHealth = 96;
    public static double playerDamage = 1;
    public double currentPlayerHP;

    public static int armourTier;
    public static int weaponTier;

    public static bool gamePaused;

    public Item[] ores = new Item[DataManager.numOres];
    public Item[] metals = new Item[DataManager.numMetals];
    public Item[] gems = new Item[DataManager.numGems];
    public Item[] potions = new Item[DataManager.numPotions];
    public Item[] magicSpells = new Item[DataManager.numMagicSpells];
    public Item[] herbs = new Item[DataManager.numHerbs];
    public Item[] fruits = new Item[DataManager.numFruits];

    private void Start()
    {
        gamePaused = false;
        playerDamage = Mathf.Ceil(1 * Mathf.Pow(1.14f, weaponTier));
        currentPlayerHP = playerHealth;
    }

    private void Update()
    {
        if(playerHealth <= 0)
        {
            playerHealth = 0;
            gamePaused = true;
            LevelScript.restart = true;
        }
        if (gamePaused)
        {
            playerHealth = currentPlayerHP;
        }
        else
        {
            currentPlayerHP = playerHealth;
        }
        if(LevelScript.wave == 10)
        {
            if(weaponTier < (LevelScript.level - 1) * 10 + LevelScript.wave)
            {
                playerDamage = 0;
            }
            else
            {
                playerDamage = Mathf.Ceil(1 * Mathf.Pow(1.14f, weaponTier));
            }
        }
        else
        {
            playerDamage = Mathf.Ceil(1 * Mathf.Pow(1.14f, weaponTier));
        }
        playerHealthBar.fillAmount = (float)(playerHealth / playerMaxHealth);
    }
}