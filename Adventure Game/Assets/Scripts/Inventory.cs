﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public PlayerData pData;

    public GameObject mainCamera;

    public Item[] items = new Item[500];

    public Image[] inventorySlotImage = new Image[8];

    public Text[] inventorySlotAmount = new Text[8];

    public int itemIndex;
    public int inventoryPage = 1;

    private void Awake()
    {
        pData = mainCamera.GetComponent<PlayerData>();
    }

    private void Start()
    {
        itemIndex = 0;
        for(int i = 0; i < DataManager.numPotions; i++)
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
        for(int i = 0; i < 8; i++)
        {
            if(items[inventoryPage * 8 - 8 + i] != null)
            {
                inventorySlotAmount[i].text = items[inventoryPage * 8 - 8 + i].amount.ToString();
                inventorySlotImage[i].sprite = items[inventoryPage * 8 - 8 + i].sprite;
            }
            else
            {
                inventorySlotAmount[i].text = "";
                inventorySlotImage[i].sprite = null;
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