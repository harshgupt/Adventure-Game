using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour {

    public Transform mob;
    public Transform boss;

    float yPos1 = 1.5f;
    float yPos2 = -1.5f;
    float yPos3 = 0f;
    float yPos4 = 3f;
    float yPos5 = -3f;

    public static int mobsKilled;

    public static bool bossKilled;

    private void Start()
    {
        mobsKilled = 0;
        bossKilled = false;
        Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
        SpawnMobs(2);
    }

    private void Update()
    {
        if (bossKilled)
        {
            bossKilled = false;
            LevelScript.nextLevel = true;
            Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            SpawnMobs(2);
        }
        if(mobsKilled == 2 && LevelScript.wave <= 3)
        {
            mobsKilled = 0;
            LevelScript.wave++;
            Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            CheckWaveNo();
        }
        else if(mobsKilled == 3 && LevelScript.wave <= 6)
        {
            mobsKilled = 0;
            LevelScript.wave++;
            Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            CheckWaveNo();
        }
        else if (mobsKilled == 5 && LevelScript.wave <= 9)
        {
            mobsKilled = 0;
            LevelScript.wave++;
            Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            CheckWaveNo();
        }
    }

    public void CheckWaveNo()
    {
        if (LevelScript.wave <= 3)
        {
            SpawnMobs(2);
        }
        else if (LevelScript.wave <= 6)
        {
            SpawnMobs(3);
        }
        else if (LevelScript.wave <= 9)
        {
            SpawnMobs(5);
        }
        else if (LevelScript.wave == 10)
        {
            SpawnBoss();
        }
    }

    public void SpawnMobs(int numMobs)
    {
        Instantiate(mob, new Vector2(6, yPos1), Quaternion.identity);
        Instantiate(mob, new Vector2(6, yPos2), Quaternion.identity);
        if (numMobs >= 3)
        {
            Instantiate(mob, new Vector2(8, yPos3), Quaternion.identity);
            if (numMobs == 5)
            {
                Instantiate(mob, new Vector2(8, yPos4), Quaternion.identity);
                Instantiate(mob, new Vector2(8, yPos5), Quaternion.identity);
            }
        }
    }

    public void SpawnBoss()
    {
        Instantiate(boss, new Vector2(6, 0), Quaternion.identity);
    }
}
