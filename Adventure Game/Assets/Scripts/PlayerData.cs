using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour {

    public Image playerHealthBar;

    float playerMaxHealth = 100;
    public static float coins;
    public static float playerHealth = 100;

    public static int[] armourTier = new int[DataManager.numArmour];
    public static int weaponTier;

    public Item[] ores = new Item[DataManager.numOres];
    public Item[] metals = new Item[DataManager.numMetals];
    public Item[] gems = new Item[DataManager.numGems];
    public Item[] potions = new Item[DataManager.numPotions];
    public Item[] herbs = new Item[DataManager.numHerbs];
    public Item[] fruits = new Item[DataManager.numFruits];

    private void Update()
    {
        playerHealthBar.fillAmount = playerHealth / playerMaxHealth;
    }
}