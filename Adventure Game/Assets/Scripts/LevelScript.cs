using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    public static int level = 1;
    public static int wave = 1;

    public static bool nextLevel = false;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Start")
        {
            LoadLevel();
        }
    }

    private void Update()
    {
        if(nextLevel)
        {
            nextLevel = false;
            wave = 0;
            level++;
        }
    }

    public void LoadLevel()
    {
        if (File.Exists(Path.Combine(Application.streamingAssetsPath, "data.json")))
        {
            string data = File.ReadAllText(Path.Combine(Application.streamingAssetsPath, "data.json"));
            PlayerDataJSON loadedData = JsonUtility.FromJson<PlayerDataJSON>(data);
            level = loadedData.Level;
            wave = loadedData.Wave;
        }
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
