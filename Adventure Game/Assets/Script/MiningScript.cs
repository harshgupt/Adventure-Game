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
            Inventory.copperOre++;
            amountText.text = Inventory.copperOre.ToString();
        }
        else if (gameObject.tag == "Tin Ore")
        {
            Inventory.tinOre++;
            amountText.text = Inventory.tinOre.ToString();
        }
        else if (gameObject.tag == "Iron Ore")
        {
            Inventory.ironOre++;
            amountText.text = Inventory.ironOre.ToString();
        }
        else if (gameObject.tag == "Coal Ore")
        {
            Inventory.coalOre++;
            amountText.text = Inventory.coalOre.ToString();
        }
        else if (gameObject.tag == "Lead Ore")
        {
            Inventory.leadOre++;
            amountText.text = Inventory.leadOre.ToString();
        }
    }
}