using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    public const int numArmour = 6;
    public const int numTools = 2;
    public const int numOres = 9;
    public const int numMetals = 13;

    public static int coins;
    public static int playerLevel;

    //Weapons and Armour
    public static int[] armour = new int[numArmour];
    /*public static int weaponTier;
    public static int helmTier;
    public static int chestplateTier;
    public static int gauntletsTier;
    public static int leggingsTier;
    public static int bootsTier;*/

    //Tools
    public static int pickaxeTier;
    public static int woodaxeTier;

    //Metals and Alloys
    public static int[] ores = new int[numOres];
    public static int[] metals = new int[numMetals];
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
    public static int mysticalMetal;*/
}
