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
            PlayerData.ores[3] = loadedData.CoalOre;
            PlayerData.ores[4] = loadedData.LeadOre;
            PlayerData.ores[5] = loadedData.MithrilOre;
            PlayerData.ores[6] = loadedData.AdamantineOre;
            PlayerData.ores[7] = loadedData.QuicksilverOre;
            PlayerData.ores[8] = loadedData.MeteoriteOre;
            PlayerData.metals[0] = loadedData.Copper;
            PlayerData.metals[1] = loadedData.Tin;
            PlayerData.metals[2] = loadedData.Bronze;
            PlayerData.metals[3] = loadedData.Iron;
            PlayerData.metals[4] = loadedData.Steel;
            PlayerData.metals[5] = loadedData.Lead;
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
            CoalOre = PlayerData.ores[3],
            LeadOre = PlayerData.ores[4],
            MithrilOre = PlayerData.ores[5],
            AdamantineOre = PlayerData.ores[6],
            QuicksilverOre = PlayerData.ores[7],
            MeteoriteOre = PlayerData.ores[8],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Steel = PlayerData.metals[4],
            Lead = PlayerData.metals[5],
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
            WoodaxeTier = PlayerData.armourTier[8]
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Written");
    }

    public void ResetData()
    {
        PlayerData.coins = 0;
        for(int i = 0; i < numOres; i++)
        {
            PlayerData.ores[i] = 0;
        }
        for (int i = 0; i < numMetals; i++)
        {
            PlayerData.metals[i] = 0;
        }
        for (int i = 0; i < numArmour; i++)
        {
            PlayerData.armourTier[i] = 0;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = 0,
            CopperOre = 0,
            TinOre = 0,
            IronOre = 0,
            CoalOre = 0,
            LeadOre = 0,
            MithrilOre = 0,
            AdamantineOre = 0,
            QuicksilverOre = 0,
            MeteoriteOre = 0,
            Copper = 0,
            Tin = 0,
            Bronze = 0,
            Iron = 0,
            Steel = 0,
            Lead = 0,
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
            WoodaxeTier = 0
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
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = 1,
            CopperOre = 1,
            TinOre = 1,
            IronOre = 1,
            CoalOre = 1,
            LeadOre = 1,
            MithrilOre = 1,
            AdamantineOre = 1,
            QuicksilverOre = 1,
            MeteoriteOre = 1,
            Copper = 1,
            Tin = 1,
            Bronze = 1,
            Iron = 1,
            Steel = 1,
            Lead = 1,
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
            WoodaxeTier = 1
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
    }
}
