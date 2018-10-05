using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour {
    
    string dataFilePath;

    public static bool saveData;
    public static float saveTimer;

    public const int numArmour = 9;
    public const int numOres = 9;
    public const int numMetals = 14;
    public const int numPotions = 18;

    #region To view data in runtime only
    public int Coins;
    public int PlayerLevel;

    //Armour, Weapons and Tools
    public int HelmTier;
    public int ChestplateTier;
    public int GauntletsTier;
    public int LeggingsTier;
    public int BootsTier;
    public int ShieldTier;
    public int WeaponTier;
    public int PickaxeTier;
    public int WoodaxeTier;

    //Metals and Alloys
    public int CopperOre;
    public int TinOre;
    public int IronOre;
    public int CoalOre;
    public int LeadOre;
    public int MithrilOre;
    public int AdamantineOre;
    public int QuicksilverOre;
    public int MeteoriteOre;
    public int Copper;
    public int Tin;
    public int Bronze;
    public int Iron;
    public int Lead;
    public int Steel;
    public int WhiteMetal;
    public int BlackMetal;
    public int Mithril;
    public int Adamantine;
    public int Quicksilver;
    public int Meteorite;
    public int MysticalMetal;
    public int InfinitiumMetal;

    //Potions
    public int HealthPotion1;
    public int HealthPotion2;
    public int HealthPotion3;
    public int HealthPotion4;
    public int HealthPotion5;
    public int HealthPotion6;
    public int AttackPotion1;
    public int AttackPotion2;
    public int AttackPotion3;
    public int AttackPotion4;
    public int AttackPotion5;
    public int AttackPotion6;
    public int DefencePotion1;
    public int DefencePotion2;
    public int DefencePotion3;
    public int DefencePotion4;
    public int DefencePotion5;
    public int DefencePotion6;
    #endregion

    private void Start()
    {
        dataFilePath = Path.Combine(Application.streamingAssetsPath, "data.json");
        if(SceneManager.GetActiveScene().name == "Main")
        {
            LoadGameData();
        }
    }

    private void Update()
    {
        saveTimer += Time.deltaTime;
        if (saveTimer >= 0.5f)
        {
            saveTimer = 0;
            SaveGameData();
        }
        if (saveData)
        {
            saveData = false;
            SaveGameData();
        }

        #region To view data in runtime only

        Coins = PlayerData.coins;
        CopperOre = PlayerData.ores[0];
        TinOre = PlayerData.ores[1];
        IronOre = PlayerData.ores[2];
        LeadOre = PlayerData.ores[3];
        CoalOre = PlayerData.ores[4];
        MithrilOre = PlayerData.ores[5];
        AdamantineOre = PlayerData.ores[6];
        QuicksilverOre = PlayerData.ores[7];
        MeteoriteOre = PlayerData.ores[8];
        Copper = PlayerData.metals[0];
        Tin = PlayerData.metals[1];
        Bronze = PlayerData.metals[2];
        Iron = PlayerData.metals[3];
        Lead = PlayerData.metals[4];
        Steel = PlayerData.metals[5];
        WhiteMetal = PlayerData.metals[6];
        BlackMetal = PlayerData.metals[7];
        Mithril = PlayerData.metals[8];
        Adamantine = PlayerData.metals[9];
        Quicksilver = PlayerData.metals[10];
        Meteorite = PlayerData.metals[11];
        MysticalMetal = PlayerData.metals[12];
        InfinitiumMetal = PlayerData.metals[13];
        HelmTier = PlayerData.armourTier[0];
        ChestplateTier = PlayerData.armourTier[1];
        GauntletsTier = PlayerData.armourTier[2];
        LeggingsTier = PlayerData.armourTier[3];
        BootsTier = PlayerData.armourTier[4];
        ShieldTier = PlayerData.armourTier[5];
        WeaponTier = PlayerData.armourTier[6];
        PickaxeTier = PlayerData.armourTier[7];
        WoodaxeTier = PlayerData.armourTier[8];
        HealthPotion1 = PlayerData.potions[0];
        HealthPotion2 = PlayerData.potions[1];
        HealthPotion3 = PlayerData.potions[2];
        HealthPotion4 = PlayerData.potions[3];
        HealthPotion5 = PlayerData.potions[4];
        HealthPotion6 = PlayerData.potions[5];
        AttackPotion1 = PlayerData.potions[6];
        AttackPotion2 = PlayerData.potions[7];
        AttackPotion3 = PlayerData.potions[8];
        AttackPotion4 = PlayerData.potions[9];
        AttackPotion5 = PlayerData.potions[10];
        AttackPotion6 = PlayerData.potions[11];
        DefencePotion1 = PlayerData.potions[12];
        DefencePotion2 = PlayerData.potions[13];
        DefencePotion3 = PlayerData.potions[14];
        DefencePotion4 = PlayerData.potions[15];
        DefencePotion5 = PlayerData.potions[16];
        DefencePotion6 = PlayerData.potions[17];
        #endregion
    }

    public void LoadGameData()
    {
        if (File.Exists(dataFilePath))
        {
            string data = File.ReadAllText(dataFilePath);
            PlayerDataJSON loadedData = JsonUtility.FromJson<PlayerDataJSON>(data);
            PlayerData.coins = loadedData.Coins;
            PlayerData.ores[0] = loadedData.CopperOre;
            PlayerData.ores[1] = loadedData.TinOre;
            PlayerData.ores[2] = loadedData.IronOre;
            PlayerData.ores[3] = loadedData.LeadOre;
            PlayerData.ores[4] = loadedData.CoalOre;
            PlayerData.ores[5] = loadedData.MithrilOre;
            PlayerData.ores[6] = loadedData.AdamantineOre;
            PlayerData.ores[7] = loadedData.QuicksilverOre;
            PlayerData.ores[8] = loadedData.MeteoriteOre;
            PlayerData.metals[0] = loadedData.Copper;
            PlayerData.metals[1] = loadedData.Tin;
            PlayerData.metals[2] = loadedData.Bronze;
            PlayerData.metals[3] = loadedData.Iron;
            PlayerData.metals[4] = loadedData.Lead;
            PlayerData.metals[5] = loadedData.Steel;
            PlayerData.metals[6] = loadedData.WhiteMetal;
            PlayerData.metals[7] = loadedData.BlackMetal;
            PlayerData.metals[8] = loadedData.Mithril;
            PlayerData.metals[9] = loadedData.Adamantine;
            PlayerData.metals[10] = loadedData.Quicksilver;
            PlayerData.metals[11] = loadedData.Meteorite;
            PlayerData.metals[12] = loadedData.MysticalMetal;
            PlayerData.metals[13] = loadedData.InfinitiumMetal;
            PlayerData.armourTier[0] = loadedData.HelmTier;
            PlayerData.armourTier[1] = loadedData.ChestplateTier;
            PlayerData.armourTier[2] = loadedData.GauntletsTier;
            PlayerData.armourTier[3] = loadedData.LeggingsTier;
            PlayerData.armourTier[4] = loadedData.BootsTier;
            PlayerData.armourTier[5] = loadedData.ShieldTier;
            PlayerData.armourTier[6] = loadedData.WeaponTier;
            PlayerData.armourTier[7] = loadedData.PickaxeTier;
            PlayerData.armourTier[8] = loadedData.WoodaxeTier;
            PlayerData.potions[0] = loadedData.HealthPotion1;
            PlayerData.potions[1] = loadedData.HealthPotion2;
            PlayerData.potions[2] = loadedData.HealthPotion3;
            PlayerData.potions[3] = loadedData.HealthPotion4;
            PlayerData.potions[4] = loadedData.HealthPotion5;
            PlayerData.potions[5] = loadedData.HealthPotion6;
            PlayerData.potions[6] = loadedData.AttackPotion1;
            PlayerData.potions[7] = loadedData.AttackPotion2;
            PlayerData.potions[8] = loadedData.AttackPotion3;
            PlayerData.potions[9] = loadedData.AttackPotion4;
            PlayerData.potions[10] = loadedData.AttackPotion5;
            PlayerData.potions[11] = loadedData.AttackPotion6;
            PlayerData.potions[12] = loadedData.DefencePotion1;
            PlayerData.potions[13] = loadedData.DefencePotion2;
            PlayerData.potions[14] = loadedData.DefencePotion3;
            PlayerData.potions[15] = loadedData.DefencePotion4;
            PlayerData.potions[16] = loadedData.DefencePotion5;
            PlayerData.potions[17] = loadedData.DefencePotion6;
        }
        //Debug.Log("Data Loaded");
    }

    public void SaveGameData()
    {
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            LeadOre = PlayerData.ores[3],
            CoalOre = PlayerData.ores[4],
            MithrilOre = PlayerData.ores[5],
            AdamantineOre = PlayerData.ores[6],
            QuicksilverOre = PlayerData.ores[7],
            MeteoriteOre = PlayerData.ores[8],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Lead = PlayerData.metals[4],
            Steel = PlayerData.metals[5],
            WhiteMetal = PlayerData.metals[6],
            BlackMetal = PlayerData.metals[7],
            Mithril = PlayerData.metals[8],
            Adamantine = PlayerData.metals[9],
            Quicksilver = PlayerData.metals[10],
            Meteorite = PlayerData.metals[11],
            MysticalMetal = PlayerData.metals[12],
            InfinitiumMetal = PlayerData.metals[13],
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            WoodaxeTier = PlayerData.armourTier[8],
            HealthPotion1 = PlayerData.potions[0],
            HealthPotion2 = PlayerData.potions[1],
            HealthPotion3 = PlayerData.potions[2],
            HealthPotion4 = PlayerData.potions[3],
            HealthPotion5 = PlayerData.potions[4],
            HealthPotion6 = PlayerData.potions[5],
            AttackPotion1 = PlayerData.potions[6],
            AttackPotion2 = PlayerData.potions[7],
            AttackPotion3 = PlayerData.potions[8],
            AttackPotion4 = PlayerData.potions[9],
            AttackPotion5 = PlayerData.potions[10],
            AttackPotion6 = PlayerData.potions[11],
            DefencePotion1 = PlayerData.potions[12],
            DefencePotion2 = PlayerData.potions[13],
            DefencePotion3 = PlayerData.potions[14],
            DefencePotion4 = PlayerData.potions[15],
            DefencePotion5 = PlayerData.potions[16],
            DefencePotion6 = PlayerData.potions[17]
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Written");
    }

    public void ResetData()
    {
        PlayerData.coins = 0;
        for (int i = 0; i < numArmour; i++)
        {
            PlayerData.armourTier[i] = 0;
        }
        for (int i = 0; i < numOres; i++)
        {
            PlayerData.ores[i] = 0;
        }
        for (int i = 0; i < numMetals; i++)
        {
            PlayerData.metals[i] = 0;
        }
        for (int i = 0; i < numPotions; i++)
        {
            PlayerData.potions[i] = 0;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = 0,
            CopperOre = 0,
            TinOre = 0,
            IronOre = 0,
            LeadOre = 0,
            CoalOre = 0,
            MithrilOre = 0,
            AdamantineOre = 0,
            QuicksilverOre = 0,
            MeteoriteOre = 0,
            Copper = 0,
            Tin = 0,
            Bronze = 0,
            Iron = 0,
            Lead = 0,
            Steel = 0,
            WhiteMetal = 0,
            BlackMetal = 0,
            Mithril = 0,
            Adamantine = 0,
            Quicksilver = 0,
            Meteorite = 0,
            MysticalMetal = 0,
            InfinitiumMetal = 0,
            HelmTier = 0,
            ChestplateTier = 0,
            GauntletsTier = 0,
            LeggingsTier = 0,
            BootsTier = 0,
            ShieldTier = 0,
            WeaponTier = 0,
            PickaxeTier = 0,
            WoodaxeTier = 0,
            HealthPotion1 = 0,
            HealthPotion2 = 0,
            HealthPotion3 = 0,
            HealthPotion4 = 0,
            HealthPotion5 = 0,
            HealthPotion6 = 0,
            AttackPotion1 = 0,
            AttackPotion2 = 0,
            AttackPotion3 = 0,
            AttackPotion4 = 0,
            AttackPotion5 = 0,
            AttackPotion6 = 0,
            DefencePotion1 = 0,
            DefencePotion2 = 0,
            DefencePotion3 = 0,
            DefencePotion4 = 0,
            DefencePotion5 = 0,
            DefencePotion6 = 0
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Reset");
    }

    public void OneOfEach()
    {
        PlayerData.coins = 1;
        for (int i = 0; i < numOres; i++)
        {
            PlayerData.ores[i] = 1;
        }
        for (int i = 0; i < numMetals; i++)
        {
            PlayerData.metals[i] = 1;
        }
        for (int i = 0; i < numArmour; i++)
        {
            PlayerData.armourTier[i] = 1;
        }
        for (int i = 0; i < numPotions; i++)
        {
            PlayerData.potions[i] = 1;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = 1,
            CopperOre = 1,
            TinOre = 1,
            IronOre = 1,
            LeadOre = 1,
            CoalOre = 1,
            MithrilOre = 1,
            AdamantineOre = 1,
            QuicksilverOre = 1,
            MeteoriteOre = 1,
            Copper = 1,
            Tin = 1,
            Bronze = 1,
            Iron = 1,
            Lead = 1,
            Steel = 1,
            WhiteMetal = 1,
            BlackMetal = 1,
            Mithril = 1,
            Adamantine = 1,
            Quicksilver = 1,
            Meteorite = 1,
            MysticalMetal = 1,
            InfinitiumMetal = 1,
            HelmTier = 1,
            ChestplateTier = 1,
            GauntletsTier = 1,
            LeggingsTier = 1,
            BootsTier = 1,
            ShieldTier = 1,
            WeaponTier = 1,
            PickaxeTier = 1,
            WoodaxeTier = 1,
            HealthPotion1 = 1,
            HealthPotion2 = 1,
            HealthPotion3 = 1,
            HealthPotion4 = 1,
            HealthPotion5 = 1,
            HealthPotion6 = 1,
            AttackPotion1 = 1,
            AttackPotion2 = 1,
            AttackPotion3 = 1,
            AttackPotion4 = 1,
            AttackPotion5 = 1,
            AttackPotion6 = 1,
            DefencePotion1 = 1,
            DefencePotion2 = 1,
            DefencePotion3 = 1,
            DefencePotion4 = 1,
            DefencePotion5 = 1,
            DefencePotion6 = 1
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
    }
}