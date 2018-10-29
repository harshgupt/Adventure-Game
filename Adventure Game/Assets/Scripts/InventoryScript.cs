using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryScript : MonoBehaviour{

    public PlayerData pData;

    public const int numInventorySlots = 60;

    public Image[] itemImages = new Image[numInventorySlots];
    public Text[] itemAmounts = new Text[numInventorySlots];
    public string[] itemName = new string[numInventorySlots];

    /*public void AddItem(string name, Sprite sprite, float amount)
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
    
    public void RemoveItem(string name, float amount)
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
    }*/

    void Update()
    {
        int inventoryNo = 0;
        if (SceneManager.GetActiveScene().name == "Main")
        {
            for (int i = 0; i < DataManager.numPotions; i++)
            {
                if (pData.potions[i].amount != 0)
                {
                    itemImages[inventoryNo].sprite = pData.potions[i].sprite;
                    itemAmounts[inventoryNo].text = pData.potions[i].amount.ToString();
                    itemName[inventoryNo] = pData.potions[i].name;
                    inventoryNo++;
                }
            }
            for (int i = 0; i < DataManager.numFruits; i++)
            {
                if (pData.fruits[i].amount != 0)
                {
                    itemImages[inventoryNo].sprite = pData.fruits[i].sprite;
                    itemAmounts[inventoryNo].text = pData.fruits[i].amount.ToString();
                    itemName[inventoryNo] = pData.fruits[i].name;
                    inventoryNo++;
                }
            }
        }
    }
}
