using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelting : MonoBehaviour {

    public InventoryScript inventoryScript;
    public Item[] metals = new Item[13];
    
    public void SmeltCopper()
    {
        if(PlayerData.ores[0] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[0]++;
            PlayerData.ores[0]--;
            inventoryScript.AddItem("Copper", metals[0].sprite, PlayerData.metals[0]);
            inventoryScript.RemoveItem("Copper Ore", PlayerData.ores[0]);
        }
    }

    public void SmeltTin()
    {
        if (PlayerData.ores[1] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[1]++;
            PlayerData.ores[1]--;
            inventoryScript.AddItem("Tin", metals[1].sprite, PlayerData.metals[1]);
            inventoryScript.RemoveItem("Tin Ore", PlayerData.ores[1]);
        }
    }

    public void SmeltBronze()
    {
        if (PlayerData.ores[0] == 0 || PlayerData.ores[1] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[2]++;
            PlayerData.ores[0]--;
            PlayerData.ores[1]--;
            inventoryScript.AddItem("Bronze", metals[2].sprite, PlayerData.metals[2]);
            inventoryScript.RemoveItem("Copper Ore", PlayerData.ores[0]);
            inventoryScript.RemoveItem("Tin Ore", PlayerData.ores[1]);
        }
    }

    public void SmeltIron()
    {
        if (PlayerData.ores[2] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[3]++;
            PlayerData.ores[2]--;
            inventoryScript.AddItem("Iron", metals[3].sprite, PlayerData.metals[3]);
            inventoryScript.RemoveItem("Iron Ore", PlayerData.ores[2]);
        }
    }

    public void SmeltSteel()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[3] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[4]++;
            PlayerData.ores[2]--;
            PlayerData.ores[3]--;
            inventoryScript.AddItem("Steel", metals[4].sprite, PlayerData.metals[4]);
            inventoryScript.RemoveItem("Iron Ore", PlayerData.ores[2]);
            inventoryScript.RemoveItem("Coal Ore", PlayerData.ores[3]);
        }
    }

    public void SmeltLead()
    {
        if (PlayerData.ores[4] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[5]++;
            PlayerData.ores[4]--;
            inventoryScript.AddItem("Lead", metals[5].sprite, PlayerData.metals[5]);
            inventoryScript.RemoveItem("Lead Ore", PlayerData.ores[4]);
        }
    }

    public void SmeltWhiteMetal()
    {
        if (PlayerData.ores[4] == 0 || PlayerData.ores[1] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[6]++;
            PlayerData.ores[4]--;
            PlayerData.ores[1]--;
            inventoryScript.AddItem("White Metal", metals[6].sprite, PlayerData.metals[6]);
            inventoryScript.RemoveItem("Lead Ore", PlayerData.ores[4]);
            inventoryScript.RemoveItem("Tin Ore", PlayerData.ores[1]);
        }
    }

    public void SmeltBlackMetal()
    {
        if (PlayerData.ores[4] == 0 || PlayerData.ores[0] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[7]++;
            PlayerData.ores[4]--;
            PlayerData.ores[0]--;
            inventoryScript.AddItem("Black Metal", metals[7].sprite, PlayerData.metals[7]);
            inventoryScript.RemoveItem("Lead Ore", PlayerData.ores[4]);
            inventoryScript.RemoveItem("Copper Ore", PlayerData.ores[0]);
        }
    }

    public void SmeltMithril()
    {
        if (PlayerData.ores[5] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[8]++;
            PlayerData.ores[5]--;
            inventoryScript.AddItem("Mithril", metals[8].sprite, PlayerData.metals[8]);
            inventoryScript.RemoveItem("Mithril Ore", PlayerData.ores[5]);
        }
    }

    public void SmeltAdamantine()
    {
        if (PlayerData.ores[6] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[9]++;
            PlayerData.ores[6]--;
            inventoryScript.AddItem("Adamantine", metals[9].sprite, PlayerData.metals[9]);
            inventoryScript.RemoveItem("Adamantine Ore", PlayerData.ores[6]);
        }
    }

    public void SmeltQuicksilver()
    {
        if (PlayerData.ores[7] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[10]++;
            PlayerData.ores[7]--;
            inventoryScript.AddItem("Quicksilver", metals[10].sprite, PlayerData.metals[10]);
            inventoryScript.RemoveItem("Quicksilver Ore", PlayerData.ores[7]);
        }
    }

    public void SmeltMeteorite()
    {
        if (PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[11]++;
            PlayerData.ores[8]--;
            inventoryScript.AddItem("Meteorite", metals[11].sprite, PlayerData.metals[11]);
            inventoryScript.RemoveItem("Meteorite Ore", PlayerData.ores[8]);
        }
    }

    public void SmeltMysticalMetal()
    {
        if (PlayerData.ores[5] == 0 || PlayerData.ores[6] == 0 || PlayerData.ores[7] == 0 || PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[12]++;
            PlayerData.ores[5]--;
            PlayerData.ores[6]--;
            PlayerData.ores[7]--;
            PlayerData.ores[8]--;
            inventoryScript.AddItem("Mystical Metal", metals[12].sprite, PlayerData.metals[12]);
            inventoryScript.RemoveItem("Mithril Ore", PlayerData.ores[5]);
            inventoryScript.RemoveItem("Adamantine Ore", PlayerData.ores[6]);
            inventoryScript.RemoveItem("Quicksilver Ore", PlayerData.ores[7]);
            inventoryScript.RemoveItem("Meteorite Ore", PlayerData.ores[8]);
        }
    }
}
