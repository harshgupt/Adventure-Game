using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryScript : MonoBehaviour{

    public const int numInventorySlots = 60;

    public Image[] itemImages = new Image[numInventorySlots];
    public Text[] itemAmounts = new Text[numInventorySlots];
    public string[] itemName = new string[numInventorySlots];
    public Item[] metals = new Item[DataManager.numMetals];
    public Item[] ores = new Item[DataManager.numOres];
    public Item[] potions = new Item[DataManager.numPotions];

    public void AddItem(string name, Sprite sprite, int amount)
    {
        for(int i = 0; i < numInventorySlots; i++)
        {
            if(itemName[i] == name)
            {
                itemAmounts[i].text = amount.ToString();
                return;
            }
            else if(itemName[i] == "")
            {
                itemName[i] = name;
                itemImages[i].sprite = sprite;
                itemAmounts[i].text = amount.ToString();
                return;
            }
        }
    }
    
    public void RemoveItem(string name, int amount)
    {
        for(int i = 0; i < numInventorySlots; i++)
        {
            if(itemName[i] == name)
            {
                if(amount == 0)
                {
                    for (int j = i; j < numInventorySlots-1; j++)
                    {
                        if(itemName[j+1] != "")
                        {
                            itemName[j] = itemName[j + 1];
                            itemImages[j].sprite = itemImages[j + 1].sprite;
                            itemAmounts[j].text = itemAmounts[j + 1].text;
                        }
                        else
                        {
                            itemName[j] = "";
                            itemImages[j].sprite = null;
                            itemAmounts[j].text = "";
                            return;
                        }
                    }
                }
                else
                {
                    itemAmounts[i].text = amount.ToString();
                    return;
                }
            }
        }
    }

    void Update()
    {
        int inventoryNo = 0;
        if(SceneManager.GetActiveScene().name == "Main")
        {
            if(OpenUI.inventoryDisplayType == "All")
            {
                for (int i = 0; i < DataManager.numMetals; i++)
                {
                    if (PlayerData.metals[i] != 0)
                    {
                        itemImages[inventoryNo].sprite = metals[i].sprite;
                        itemAmounts[inventoryNo].text = PlayerData.metals[i].ToString();
                        itemName[inventoryNo] = metals[i].name;
                        inventoryNo++;
                    }
                }
                for (int i = 0; i < DataManager.numOres; i++)
                {
                    if (PlayerData.ores[i] != 0)
                    {
                        itemImages[inventoryNo].sprite = ores[i].sprite;
                        itemAmounts[inventoryNo].text = PlayerData.ores[i].ToString();
                        itemName[inventoryNo] = ores[i].name;
                        inventoryNo++;
                    }
                }
                for (int i = 0; i < DataManager.numPotions; i++)
                {
                    if (PlayerData.potions[i] != 0)
                    {
                        itemImages[inventoryNo].sprite = potions[i].sprite;
                        itemAmounts[inventoryNo].text = PlayerData.potions[i].ToString();
                        itemName[inventoryNo] = potions[i].name;
                        inventoryNo++;
                    }
                }
            }
            else if (OpenUI.inventoryDisplayType == "Battle")
            {
                for (int i = 0; i < DataManager.numPotions; i++)
                {
                    if (PlayerData.potions[i] != 0)
                    {
                        itemImages[inventoryNo].sprite = potions[i].sprite;
                        itemAmounts[inventoryNo].text = PlayerData.potions[i].ToString();
                        itemName[inventoryNo] = potions[i].name;
                        inventoryNo++;
                    }
                }
            }
        }
    }
}
