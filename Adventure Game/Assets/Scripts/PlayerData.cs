using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {
    
    public static int coins;
    
    public static int[] armourTier = new int[DataManager.numArmour];
    public static int[] ores = new int[DataManager.numOres];
    public static int[] metals = new int[DataManager.numMetals];
    public static int[] gems = new int[DataManager.numGems];
    public static int[] potions = new int[DataManager.numPotions];
    public static int[] herbs = new int[DataManager.numHerbs];
    public static int[] fruits = new int[DataManager.numFruits];
}