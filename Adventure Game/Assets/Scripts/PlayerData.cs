using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour {

    public Image playerHealthBar;

    public static float playerMaxHealth = 96f;
    public static float coins;
    public static float playerHealth = 96f;
    public static float playerDamage = 1;
    public float currentPlayerHP;

    public static int[] armourTier = new int[DataManager.numArmour];
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
        gamePaused = true;
        playerDamage = Mathf.Ceil(1 * Mathf.Pow(1.14f, weaponTier));
        currentPlayerHP = playerHealth;
    }

    private void Update()
    {
        if(playerHealth <= 0)
        {
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
        playerHealthBar.fillAmount = playerHealth / playerMaxHealth;
    }
}