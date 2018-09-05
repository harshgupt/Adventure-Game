using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour {

    public Text amountText;

    public void OnMouseDown()
    {
        if(gameObject.tag == "Copper Ore")
        {
            PlayerData.ores[0]++;
        }
        else if (gameObject.tag == "Tin Ore")
        {
            PlayerData.ores[1]++;
        }
        else if (gameObject.tag == "Iron Ore")
        {
            PlayerData.ores[2]++;
        }
        else if (gameObject.tag == "Coal Ore")
        {
            PlayerData.ores[3]++;
        }
        else if (gameObject.tag == "Lead Ore")
        {
            PlayerData.ores[4]++;
        }
    }
}