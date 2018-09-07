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
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            LoadGameData();
        }
    }

    private void Update()
    {
        saveTimer += Time.deltaTime;
        if (saveTimer >= 2f)
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
            MysticalMetal = PlayerData.metals[12]
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Written");
    }
}
