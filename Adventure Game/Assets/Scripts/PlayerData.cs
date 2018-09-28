using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {
    
    public static int coins;
    public static int playerLevel;

    //Armour, Weapons and Tools
    public static int[] armourTier = new int[DataManager.numArmour];
    /*public static int helmTier;
    public static int chestplateTier;
    public static int gauntletsTier;
    public static int leggingsTier;
    public static int bootsTier;
    public static int shieldTier;
    public static int weaponTier;
    public static int pickaxeTier;
    public static int woodaxeTier;*/

    //Metals and Alloys
    public static int[] ores = new int[DataManager.numOres];
    public static int[] metals = new int[DataManager.numMetals];
    /*public static int copperOre;
    public static int tinOre;
    public static int ironOre;
    public static int coalOre;
    public static int leadOre;
    public static int mithrilOre;
    public static int adamantineOre;
    public static int quicksilverOre;
    public static int meteoriteOre;
    public static int copper;
    public static int tin;
    public static int bronze;
    public static int iron;
    public static int steel;
    public static int lead;
    public static int whiteMetal;
    public static int blackMetal;
    public static int mithril;
    public static int adamantine;
    public static int quicksilver;
    public static int meteorite;
    public static int mysticalMetal;
    public static int infinitiumMetal*/

    //Potions
    public static int[] potions = new int[DataManager.numPotions];
    /*public static int HealthPotion1;
    public static int HealthPotion2;
    public static int HealthPotion3;
    public static int HealthPotion4;
    public static int HealthPotion5;
    public static int HealthPotion6;
    public static int AttackPotion1;
    public static int AttackPotion2;
    public static int AttackPotion3;
    public static int AttackPotion4;
    public static int AttackPotion5;
    public static int AttackPotion6;
    public static int DefencePotion1;
    public static int DefencePotion2;
    public static int DefencePotion3;
    public static int DefencePotion4;
    public static int DefencePotion5;
    public static int DefencePotion6;*/
}