using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public Transform[] mobs = new Transform[DataManager.numMobs];
    public Transform[] bosses = new Transform[DataManager.numBosses];

    public static int mobsOnScreen;
    public static int bossOnScreen;

    private void Start()
    {
        for(int i = 0; i < 220; i++)
        {
            if((i + 1) % 10 != 0)
            {
                //Debug.Log("L: " + (i+1) + " HP: " + Mathf.Ceil(2 * Mathf.Pow(1.15f, i)));
            }
            else if ((i + 1) % 10 == 0)
            {
                //Debug.Log("L: " + (i + 1) + " HP: " + Mathf.Ceil(6 * Mathf.Pow(1.15f, i)));
            }
        }
    }

    private void Update()
    {
        if (mobsOnScreen == 0 && bossOnScreen == 0)
        {
            if (LevelScript.wave > 0 && LevelScript.wave <= 3)
            {
                SpawnMob(1);
                SpawnMob(2);
                //Debug.Log("Level: " + LevelScript.level + ", Mob: " + mobs[LevelScript.level - 1].name);
            }
            else if (LevelScript.wave > 3 && LevelScript.wave <= 6)
            {
                SpawnMob(1);
                SpawnMob(2);
                SpawnMob(3);
                //Debug.Log("Level: " + LevelScript.level + ", Mob: " + mobs[LevelScript.level - 1].name);
            }
            else if (LevelScript.wave > 6 && LevelScript.wave <= 9)
            {
                SpawnMob(1);
                SpawnMob(2);
                SpawnMob(3);
                SpawnMob(4);
                SpawnMob(5);
                //Debug.Log("Level: " + LevelScript.level + ", Mob: " + mobs[LevelScript.level - 1].name);
            }
            else if (LevelScript.wave == 10)
            {
                SpawnBoss();
                //Debug.Log("Level: " + LevelScript.level + ", Boss: " + bosses[LevelScript.level - 1].name);
            }
        }
    }

    public void SpawnMob(int position)
    {
        if (position == 1)
        {
            Instantiate(mobs[LevelScript.level - 1], new Vector2(6, 2f), Quaternion.identity);
        }
        else if (position == 2)
        {
            Instantiate(mobs[LevelScript.level - 1], new Vector2(6, -1f), Quaternion.identity);
        }
        else if (position == 3)
        {
            Instantiate(mobs[LevelScript.level - 1], new Vector2(8, 0.5f), Quaternion.identity);
        }
        else if (position == 4)
        {
            Instantiate(mobs[LevelScript.level - 1], new Vector2(8, 3.5f), Quaternion.identity);
        }
        else if (position == 5)
        {
            Instantiate(mobs[LevelScript.level - 1], new Vector2(8, -2.5f), Quaternion.identity);
        }
        mobsOnScreen++;
    }

    public void SpawnBoss()
    {
        Instantiate(bosses[LevelScript.level - 1], new Vector2(6, 0.5f), Quaternion.identity);
        bossOnScreen = 1;
    }
}
