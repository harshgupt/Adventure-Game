﻿using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    public GameObject gameOverUI;
    public GameObject gameWinUI;

    public string dataFilePath;

    public static int level = 1;
    public static int wave = 1;
    public static int playerHP = 100;
    public int currentHour;
    public int currentDay;
    public int savedHour;
    public int savedDay;
    public int numDays;
    public int numHours;

    public static bool restart = false;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Start")
        {
            //Load Level
            dataFilePath = GetApplicationPath() + "data.json";
            if (!File.Exists(dataFilePath))
            {
                TextAsset tempData = (TextAsset)Resources.Load("defaultData", typeof(TextAsset));
                var writer = new StreamWriter(dataFilePath);
                writer.Write(tempData.text);
                writer.Flush();
                writer.Close();
            }
            GetData();
        }
    }

    public void Update()
    {
        if (restart)
        {
            restart = false;
            PlayerData.gamePaused = true;
            gameOverUI.SetActive(true);
        }
        if(level > 22)
        {
            level = 1;
            wave = 1;
            PlayerData.gamePaused = true;
            gameWinUI.SetActive(true);
        }
    }

    public void GetData()
    {
        PlayerDataJSON loadedData = JsonUtility.FromJson<PlayerDataJSON>(File.ReadAllText(dataFilePath));
        level = loadedData.Level;
        wave = loadedData.Wave;
        PlayerData.armourTier = loadedData.ArmourTier;
        PlayerData.playerMaxHealth = Mathf.Ceil(100 * Mathf.Pow(1.15f, PlayerData.armourTier));
        PlayerData.playerHealth = loadedData.PlayerHP;
        //Regenerating player health based on time passed
        savedHour = loadedData.Hour;
        savedDay = loadedData.DayOfYear;
        currentHour = DateTime.Now.Hour;
        currentDay = DateTime.Now.DayOfYear;
        if (currentDay < savedDay)
        {
            numDays = 366 - savedDay + currentDay;
        }
        else
        {
            numDays = currentDay - savedDay;
        }
        numHours = numDays * 24;
        if (currentHour >= savedHour)
        {
            numHours += currentHour - savedHour;
        }
        else
        {
            numHours += currentHour + 24 - savedHour;
        }
        PlayerData.playerHealth += PlayerData.playerMaxHealth / 24 * numHours;
        if (PlayerData.playerHealth > PlayerData.playerMaxHealth)
        {
            PlayerData.playerHealth = PlayerData.playerMaxHealth;
        }
    }

    public void RestartLevel()
    {
        PlayerData.playerHealth = PlayerData.playerMaxHealth;
        wave = 1;
        var enemiesOnScreen = GameObject.FindGameObjectsWithTag("Enemy");
        for (var i = 0; i < enemiesOnScreen.Length; i++)
        {
            Destroy(enemiesOnScreen[i]);
        }
        MobSpawner.bossOnScreen = 0;
        MobSpawner.mobsOnScreen = 0;
        gameOverUI.SetActive(false);
        PlayerData.gamePaused = false;
    }

    public void RestartGame()
    {
        PlayerData.gamePaused = false;
        gameWinUI.SetActive(false);
        PlayerData.playerHealth = PlayerData.playerMaxHealth;
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }

    private string GetApplicationPath()
    {
#if UNITY_EDITOR
        return Application.dataPath + "/Data/";
#elif UNITY_ANDROID
        return Application.persistentDataPath;
#elif UNITY_IPHONE
        return Application.persistentDataPath+"/";
#else
        return Application.dataPath +"/";
#endif
    }
}
