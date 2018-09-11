using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawnerTemplate : MonoBehaviour {

    public Transform mob;
    public Transform boss;
    public float timer;
    public int mobCount;

    int yCount = 1;
    
	void Start ()
    {
        timer = 0;
        Instantiate(mob, new Vector2(12, -0.5f), Quaternion.identity);
        mobCount = 1;
    }
	
	void Update ()
    {
        timer += Time.deltaTime;
        if(timer >= 2)
        {
            timer = 0;
            if(yCount >= 3)
            {
                yCount = 0;
            }
            if(mobCount < 6)
            {
                float yPos;
                switch (yCount)
                {
                    case 0:
                        yPos = -0.5f;
                        yCount++;
                        break;

                    case 1:
                        yPos = 4f;
                        yCount++;
                        break;

                    default:
                        yPos = -5f;
                        yCount++;
                        break;
                }
                Instantiate(mob, new Vector2(12, yPos), Quaternion.identity);
                mobCount++;
            }
            else if(mobCount == 6)
            {
                Instantiate(boss, new Vector2(12, 0), Quaternion.identity);
                mobCount++;
            }
        }
	}
}
