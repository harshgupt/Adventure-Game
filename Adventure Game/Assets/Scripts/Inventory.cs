using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public PlayerData pData;

    public GameObject mainCamera;

    public Image[] inventorySlotImage = new Image[8];

    public Text[] inventorySlotAmount = new Text[8];

    public static string[] inventorySlotName = new string[8];

    public int itemIndex;
    public int inventoryPage = 1;
    
    public static bool inventoryActive;

    private void Awake()
    {
        pData = mainCamera.GetComponent<PlayerData>();
    }

    private void Start()
    {
        Item[] items = new Item[500];
        itemIndex = 0;
        inventoryActive = true;
        for (int i = 0; i < DataManager.numMagicSpells; i++)
        {
            if (pData.magicSpells[i].amount != 0)
            {
                items[itemIndex] = pData.magicSpells[i];
                itemIndex++;
            }
        }
        for (int i = 0; i < DataManager.numPotions; i++)
        {
            if(pData.potions[i].amount != 0)
            {
                items[itemIndex] = pData.potions[i];
                itemIndex++;
            }
        }
        for (int i = 0; i < DataManager.numFruits; i++)
        {
            if (pData.fruits[i].amount != 0)
            {
                items[itemIndex] = pData.fruits[i];
                itemIndex++;
            }
        }
    }

    private void Update()
    {
        Item[] items = new Item[500];
        itemIndex = 0;
        inventoryActive = true;
        for (int i = 0; i < DataManager.numMagicSpells; i++)
        {
            if (pData.magicSpells[i].amount != 0)
            {
                items[itemIndex] = pData.magicSpells[i];
                itemIndex++;
            }
        }
        for (int i = 0; i < DataManager.numPotions; i++)
        {
            if (pData.potions[i].amount != 0)
            {
                items[itemIndex] = pData.potions[i];
                itemIndex++;
            }
        }
        for (int i = 0; i < DataManager.numFruits; i++)
        {
            if (pData.fruits[i].amount != 0)
            {
                items[itemIndex] = pData.fruits[i];
                itemIndex++;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if(items[inventoryPage * 8 - 8 + i] != null)
            {
                inventorySlotAmount[i].text = items[inventoryPage * 8 - 8 + i].amount.ToString();
                inventorySlotImage[i].sprite = items[inventoryPage * 8 - 8 + i].sprite;
                inventorySlotName[i] = items[inventoryPage * 8 - 8 + i].name;
            }
            else
            {
                inventorySlotAmount[i].text = "";
                inventorySlotImage[i].sprite = null;
                inventorySlotName[i] = "";
            }
        }
    }

    public void LeftButton()
    {
        if(inventoryPage > 1)
        {
            inventoryPage--;
        }
        else
        {
            return;
        }
    }

    public void RightButton()
    {
        if (inventoryPage <= (itemIndex - 1)/ 8)
        {
            inventoryPage++;
        }
        else
        {
            return;
        }
    }
}
