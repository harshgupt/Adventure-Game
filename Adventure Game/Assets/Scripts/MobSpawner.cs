using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public Transform mob1;
    public Transform mob2;
    public Transform mob3;
    public Transform mob4;
    public Transform boss1;
    public Transform boss2;
    public Transform boss3;
    public Transform boss4;

    public static int mobsOnScreen;
    public static int bossOnScreen;

    private void Start()
    {
        mobsOnScreen = 0;
        bossOnScreen = 0;
        SpawnMob(1);
        SpawnMob(2);
        Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
    }

    private void Update()
    {
        if (mobsOnScreen == 0 && bossOnScreen == 0)
        {
            LevelScript.wave++;
            if (LevelScript.wave > 10)
            {
                LevelScript.nextLevel = true;
            }
            if (LevelScript.wave > 0 && LevelScript.wave <= 3)
            {
                SpawnMob(1);
                SpawnMob(2);
                Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            }
            else if (LevelScript.wave > 3 && LevelScript.wave <= 6)
            {
                SpawnMob(1);
                SpawnMob(2);
                SpawnMob(3);
                Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            }
            else if (LevelScript.wave > 6 && LevelScript.wave <= 9)
            {
                SpawnMob(1);
                SpawnMob(2);
                SpawnMob(3);
                SpawnMob(4);
                SpawnMob(5);
                Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            }
            else if (LevelScript.wave == 10)
            {
                SpawnBoss();
                Debug.Log("Level: " + LevelScript.level + ", Wave: " + LevelScript.wave);
            }
        }
    }

    public void SpawnMob(int position)
    {
        Transform mobType;
        switch (LevelScript.level)
        {
            case 1:
                mobType = mob1;
                break;
            case 2:
                mobType = mob2;
                break;
            case 3:
                mobType = mob3;
                break;
            case 4:
                mobType = mob4;
                break;
            default:
                mobType = mob1;
                break;
        }
        if (position == 1)
        {
            Instantiate(mobType, new Vector2(6, 2f), Quaternion.identity);
        }
        else if (position == 2)
        {
            Instantiate(mobType, new Vector2(6, -1f), Quaternion.identity);
        }
        else if (position == 3)
        {
            Instantiate(mobType, new Vector2(8, 0.5f), Quaternion.identity);
        }
        else if (position == 4)
        {
            Instantiate(mobType, new Vector2(8, 3.5f), Quaternion.identity);
        }
        else if (position == 5)
        {
            Instantiate(mobType, new Vector2(8, -2.5f), Quaternion.identity);
        }
        mobsOnScreen++;
    }

    public void SpawnBoss()
    {
        Transform bossType;
        switch (LevelScript.level)
        {
            case 1:
                bossType = boss1;
                break;
            case 2:
                bossType = boss2;
                break;
            case 3:
                bossType = boss3;
                break;
            case 4:
                bossType = boss4;
                break;
            default:
                bossType = boss1;
                break;
        }
        Instantiate(bossType, new Vector2(6, 0f), Quaternion.identity);
        bossOnScreen = 1;
    }
}
