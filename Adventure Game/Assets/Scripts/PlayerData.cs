using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {
    
    public static float coins;
    
    public static int[] armourTier = new int[DataManager.numArmour];
    public static int weaponTier;

    public Item[] ores = new Item[DataManager.numOres];
    public Item[] metals = new Item[DataManager.numMetals];
    public Item[] gems = new Item[DataManager.numGems];
    public Item[] potions = new Item[DataManager.numPotions];
    public Item[] herbs = new Item[DataManager.numHerbs];
    public Item[] fruits = new Item[DataManager.numFruits];
}