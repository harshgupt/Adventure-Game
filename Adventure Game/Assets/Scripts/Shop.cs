using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    public const int numShopItems = 10;

    public InventoryScript inventoryScript;

    public GameObject buyMenu;
    public GameObject sellMenu;

    public Item[] shopItems = new Item[numShopItems];

    public Button[] shopButtons = new Button[40];

    public void BuyItem(int itemNo)
    {
        int value;
        string itemName = shopItems[itemNo].name;
        switch (itemName)
        {
            case "Infinitium Metal":
                value = 2;
                if(PlayerData.coins >= value)
                {
                    PlayerData.metals[13]++;
                    inventoryScript.AddItem(itemName, shopItems[itemNo].sprite, PlayerData.metals[13]);
                    PlayerData.coins -= value;
                }
                else
                {
                    break;
                }
                break;
            case "Mystical Metal":
                value = 1;
                if (PlayerData.coins >= value)
                {
                    PlayerData.metals[12]++;
                    inventoryScript.AddItem(itemName, shopItems[itemNo].sprite, PlayerData.metals[12]);
                    PlayerData.coins -= value;
                }
                else
                {
                    break;
                }
                break;
            default:
                break;
        }
    }

    public void SellItem(int index)
    {
        switch (inventoryScript.itemName[index])
        {
            case "Copper Ore":
                PlayerData.coins += 1;
                PlayerData.ores[0]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[0]);
                break;

            case "Tin Ore":
                PlayerData.coins += 2;
                PlayerData.ores[1]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[1]);
                break;

            case "Iron Ore":
                PlayerData.coins += 3;
                PlayerData.ores[2]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[2]);
                break;

            case "Lead Ore":
                PlayerData.coins += 5;
                PlayerData.ores[3]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[3]);
                break;

            case "Coal Ore":
                PlayerData.coins += 4;
                PlayerData.ores[4]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[4]);
                break;

            case "Mithril Ore":
                PlayerData.coins += 6;
                PlayerData.ores[5]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[5]);
                break;

            case "Adamantine Ore":
                PlayerData.coins += 7;
                PlayerData.ores[6]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[6]);
                break;

            case "Quicksilver Ore":
                PlayerData.coins += 8;
                PlayerData.ores[7]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[7]);
                break;

            case "Meteorite Ore":
                PlayerData.coins += 9;
                PlayerData.ores[8]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.ores[8]);
                break;

            case "Copper":
                PlayerData.coins += 2;
                PlayerData.metals[0]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[0]);
                break;

            case "Tin":
                PlayerData.coins += 4;
                PlayerData.metals[1]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[1]);
                break;

            case "Bronze":
                PlayerData.coins += 6;
                PlayerData.metals[2]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[2]);
                break;

            case "Iron":
                PlayerData.coins += 8;
                PlayerData.metals[3]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[3]);
                break;

            case "Lead":
                PlayerData.coins += 12;
                PlayerData.metals[4]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[4]);
                break;

            case "Steel":
                PlayerData.coins += 10;
                PlayerData.metals[5]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[5]);
                break;

            case "White Metal":
                PlayerData.coins += 14;
                PlayerData.metals[6]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[6]);
                break;

            case "Black Metal":
                PlayerData.coins += 14;
                PlayerData.metals[7]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[7]);
                break;

            case "Mithril":
                PlayerData.coins += 16;
                PlayerData.metals[8]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[8]);
                break;

            case "Adamantine":
                PlayerData.coins += 18;
                PlayerData.metals[9]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[9]);
                break;

            case "Quicksilver":
                PlayerData.coins += 20;
                PlayerData.metals[10]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[10]);
                break;

            case "Meteorite":
                PlayerData.coins += 22;
                PlayerData.metals[11]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[11]);
                break;

            case "Mystical Metal":
                PlayerData.coins += 24;
                PlayerData.metals[12]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[12]);
                break;

            case "Infinitium Metal":
                PlayerData.coins += 26;
                PlayerData.metals[13]--;
                inventoryScript.RemoveItem(inventoryScript.itemName[index], PlayerData.metals[13]);
                break;

            default:
                break;
        }
    }

    public void SwitchShop(string type)
    {
        if(type == "Buy")
        {
            buyMenu.SetActive(true);
            sellMenu.SetActive(false);
        }
        else
        {
            sellMenu.SetActive(true);
            buyMenu.SetActive(false);
        }
    }

    private void Start()
    {
        for(int i = 0; i < numShopItems; i++)
        {
            shopButtons[i].interactable = true;
            shopButtons[i].image.sprite = shopItems[i].sprite;
        }
    }
}
