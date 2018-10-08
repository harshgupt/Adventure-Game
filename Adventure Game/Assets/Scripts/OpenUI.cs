using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour {

    public GameObject shopUI;
    public GameObject resourcesUI;
    public GameObject inventoryUI;
    public GameObject witchcraftUI;
    public GameObject rewardsUI;
    public GameObject settingsUI;
    public GameObject coinShopUI;
    public GameObject crystalShopUI;
    public GameObject mineUI;
    public GameObject forgeUI;
    public GameObject gemstoneMineUI;
    public GameObject potionsUI;
    public GameObject spellsUI;

    public static string inventoryDisplayType = "All";

    public void OpenShop()
    {
        if (shopUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            inventoryDisplayType = "All";
            shopUI.SetActive(true);
        }
    }

    public void OpenResources()
    {
        if (resourcesUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            resourcesUI.SetActive(true);
        }
    }

    public void OpenInventory()
    {
        if (inventoryUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            inventoryDisplayType = "Battle";
            inventoryUI.SetActive(true);
        }
    }

    public void OpenWitchcraft()
    {
        if (witchcraftUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            witchcraftUI.SetActive(true);
        }
    }

    public void OpenRewards()
    {
        if (rewardsUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            rewardsUI.SetActive(true);
        }
    }

    public void OpenSettings()
    {
        if (settingsUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            settingsUI.SetActive(true);
        }
    }

    public void OpenCoinShop()
    {
        if (coinShopUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            coinShopUI.SetActive(true);
        }
    }

    public void OpenCrystalShop()
    {
        if (crystalShopUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            crystalShopUI.SetActive(true);
        }
    }

    public void OpenMine()
    {
        mineUI.SetActive(true);
    }

    public void OpenForge()
    {
        forgeUI.SetActive(true);
    }

    public void OpenGemstoneMine()
    {
        gemstoneMineUI.SetActive(true);
    }

    public void OpenPotions()
    {
        potionsUI.SetActive(true);
    }

    public void OpenSpells()
    {
        spellsUI.SetActive(true);
    }

    public void CloseAll()
    {
        shopUI.SetActive(false);
        resourcesUI.SetActive(false);
        inventoryUI.SetActive(false);
        witchcraftUI.SetActive(false);
        rewardsUI.SetActive(false);
        settingsUI.SetActive(false);
        coinShopUI.SetActive(false);
        crystalShopUI.SetActive(false);
        mineUI.SetActive(false);
        forgeUI.SetActive(false);
        gemstoneMineUI.SetActive(false);
        potionsUI.SetActive(false);
        spellsUI.SetActive(false);
    }
}
