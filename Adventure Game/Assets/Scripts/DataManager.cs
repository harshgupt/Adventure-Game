using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour {
    
    string dataFilePath;

    public static bool saveData;
    public static float saveTimer;

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
        if (saveTimer >= 5f)
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
            PlayerData.copperOre = loadedData.CopperOre;
            PlayerData.tinOre = loadedData.TinOre;
            PlayerData.ironOre = loadedData.IronOre;
            PlayerData.coalOre = loadedData.CoalOre;
            PlayerData.leadOre = loadedData.LeadOre;
            PlayerData.mithrilOre = loadedData.MithrilOre;
            PlayerData.adamantineOre = loadedData.AdamantineOre;
            PlayerData.quicksilverOre = loadedData.QuicksilverOre;
            PlayerData.meteoriteOre = loadedData.MeteoriteOre;
            PlayerData.copper = loadedData.Copper;
            PlayerData.tin = loadedData.Tin;
            PlayerData.bronze = loadedData.Bronze;
            PlayerData.iron = loadedData.Iron;
            PlayerData.steel = loadedData.Steel;
            PlayerData.lead = loadedData.Lead;
            PlayerData.whiteMetal = loadedData.WhiteMetal;
            PlayerData.blackMetal = loadedData.BlackMetal;
            PlayerData.mithril = loadedData.Mithril;
            PlayerData.adamantine = loadedData.Adamantine;
            PlayerData.quicksilver = loadedData.Quicksilver;
            PlayerData.meteorite = loadedData.Meteorite;
            PlayerData.mysticalMetal = loadedData.MysticalMetal;
        }
        //Debug.Log("Data Loaded");
    }

    public void SaveGameData()
    {
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            CopperOre = PlayerData.copperOre,
            TinOre = PlayerData.tinOre,
            IronOre = PlayerData.ironOre,
            CoalOre = PlayerData.coalOre,
            LeadOre = PlayerData.leadOre,
            MithrilOre = PlayerData.mithrilOre,
            AdamantineOre = PlayerData.adamantineOre,
            QuicksilverOre = PlayerData.quicksilverOre,
            MeteoriteOre = PlayerData.meteoriteOre,
            Copper = PlayerData.copper,
            Tin = PlayerData.tin,
            Bronze = PlayerData.bronze,
            Iron = PlayerData.iron,
            Steel = PlayerData.steel,
            Lead = PlayerData.lead,
            WhiteMetal = PlayerData.whiteMetal,
            BlackMetal = PlayerData.blackMetal,
            Mithril = PlayerData.mithril,
            Adamantine = PlayerData.adamantine,
            Quicksilver = PlayerData.quicksilver,
            Meteorite = PlayerData.meteorite,
            MysticalMetal = PlayerData.mysticalMetal
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Written");
    }
}
