using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour {
    
    public InventoryManager inventoryManagerScript;
    public Item[] ores = new Item[9];

    public void CopperMine()
    {
        PlayerData.ores[0]++;
        inventoryManagerScript.AddItem("Copper Ore", ores[0].sprite, PlayerData.ores[0]);
    }

    public void TinMine()
    {
        PlayerData.ores[1]++;
        inventoryManagerScript.AddItem("Tin Ore", ores[1].sprite, PlayerData.ores[1]);
    }

    public void IronMine()
    {
        PlayerData.ores[2]++;
        inventoryManagerScript.AddItem("Iron Ore", ores[2].sprite, PlayerData.ores[2]);
    }

    public void CoalMine()
    {
        PlayerData.ores[3]++;
        inventoryManagerScript.AddItem("Coal Ore", ores[3].sprite, PlayerData.ores[3]);
    }

    public void LeadMine()
    {
        PlayerData.ores[4]++;
        inventoryManagerScript.AddItem("Lead Ore", ores[4].sprite, PlayerData.ores[4]);
    }

    public void MithrilMine()
    {
        PlayerData.ores[5]++;
        inventoryManagerScript.AddItem("Mithril Ore", ores[5].sprite, PlayerData.ores[5]);
    }

    public void AdamantiumMine()
    {
        PlayerData.ores[6]++;
        inventoryManagerScript.AddItem("Adamantium Ore", ores[6].sprite, PlayerData.ores[6]);
    }

    public void QuicksilverMine()
    {
        PlayerData.ores[7]++;
        inventoryManagerScript.AddItem("Quicksilver Ore", ores[7].sprite, PlayerData.ores[7]);
    }

    public void MeteoriteMine()
    {
        PlayerData.ores[8]++;
        inventoryManagerScript.AddItem("Meteorite Ore", ores[8].sprite, PlayerData.ores[8]);
    }

    /*public void OnMouseDown()
    {
        if(gameObject.tag == "Copper Ore")
        {
            PlayerData.ores[0]++;
            inventoryManagerScript.AddItem("Copper Ore", ores[0].sprite, PlayerData.ores[0]);
        }
        else if (gameObject.tag == "Tin Ore")
        {
            PlayerData.ores[1]++;
            inventoryManagerScript.AddItem("Tin Ore", ores[1].sprite, PlayerData.ores[1]);
        }
        else if (gameObject.tag == "Iron Ore")
        {
            PlayerData.ores[2]++;
            inventoryManagerScript.AddItem("Iron Ore", ores[2].sprite, PlayerData.ores[2]);
        }
        else if (gameObject.tag == "Coal Ore")
        {
            PlayerData.ores[3]++;
            inventoryManagerScript.AddItem("Coal Ore", ores[3].sprite, PlayerData.ores[3]);
        }
        else if (gameObject.tag == "Lead Ore")
        {
            PlayerData.ores[4]++;
            inventoryManagerScript.AddItem("Lead Ore", ores[4].sprite, PlayerData.ores[4]);
        }
    }*/
}