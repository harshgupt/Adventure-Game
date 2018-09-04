using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiningScript : MonoBehaviour {

    public Text amountText;

    private void Start()
    {
        
    }

    public void OnMouseDown()
    {
        if(gameObject.tag == "Copper Ore")
        {
            PlayerData.copperOre++;
            amountText.text = PlayerData.copperOre.ToString();
        }
        else if (gameObject.tag == "Tin Ore")
        {
            PlayerData.tinOre++;
            amountText.text = PlayerData.tinOre.ToString();
        }
        else if (gameObject.tag == "Iron Ore")
        {
            PlayerData.ironOre++;
            amountText.text = PlayerData.ironOre.ToString();
        }
        else if (gameObject.tag == "Coal Ore")
        {
            PlayerData.coalOre++;
            amountText.text = PlayerData.coalOre.ToString();
        }
        else if (gameObject.tag == "Lead Ore")
        {
            PlayerData.leadOre++;
            amountText.text = PlayerData.leadOre.ToString();
        }
    }
}