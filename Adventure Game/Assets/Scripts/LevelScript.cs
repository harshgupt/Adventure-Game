using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    public static int level = 1;
    public static int wave = 1;

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
            }
        }
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
