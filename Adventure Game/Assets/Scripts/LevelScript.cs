using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    public static int level = 1;
    public static int wave = 1;
    public static int playerHP = 100;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Start")
        {
            //Load Level
            if (File.Exists(Path.Combine(Application.streamingAssetsPath, "data.json")))
            {
                PlayerDataJSON loadedData = JsonUtility.FromJson<PlayerDataJSON>(File.ReadAllText(Path.Combine(Application.streamingAssetsPath, "data.json")));
                level = loadedData.Level;
                wave = loadedData.Wave;
                PlayerData.armourTier[0] = loadedData.HelmTier;
                PlayerData.armourTier[1] = loadedData.ChestplateTier;
                PlayerData.armourTier[2] = loadedData.GauntletsTier;
                PlayerData.armourTier[3] = loadedData.LeggingsTier;
                PlayerData.armourTier[4] = loadedData.BootsTier;
                PlayerData.armourTier[5] = loadedData.ShieldTier;
                PlayerData.playerMaxHealth = Mathf.Ceil(100 / 6 * (Mathf.Pow(1.15f, PlayerData.armourTier[0]) + Mathf.Pow(1.15f, PlayerData.armourTier[1]) + Mathf.Pow(1.15f, PlayerData.armourTier[2]) + Mathf.Pow(1.15f, PlayerData.armourTier[3]) + Mathf.Pow(1.15f, PlayerData.armourTier[4]) + Mathf.Pow(1.15f, PlayerData.armourTier[5])));
                PlayerData.playerHealth = loadedData.PlayerHP;

            }
        }
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
