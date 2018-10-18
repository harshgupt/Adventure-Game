using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {
    
    public static float coins;
    
    public static int[] armourTier = new int[DataManager.numArmour];
    public static int weaponTier;
    public static float[] ores = new float[DataManager.numOres];
    public static float[] metals = new float[DataManager.numMetals];
    public static float[] gems = new float[DataManager.numGems];
    public static int[] potions = new int[DataManager.numPotions];
    public static int[] herbs = new int[DataManager.numHerbs];
    public static int[] fruits = new int[DataManager.numFruits];
}