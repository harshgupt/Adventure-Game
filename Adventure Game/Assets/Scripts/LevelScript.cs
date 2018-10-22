using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour {

    public static int level = 1;
    public static int wave = 1;

    public static bool nextLevel = false;

    private void Update()
    {
        if(nextLevel)
        {
            nextLevel = false;
            wave = 0;
            level++;
        }
    }
}
