using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour{

    public Blade bladeGameScript;
    public Blade bladeUIScript;

    public GameObject bladeGame;
    public GameObject bladeUI;
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
    public GameObject herbsUI;
    public GameObject fruitsUI;

    public void OpenShop()
    {
        if (shopUI.activeSelf)
        {
            CloseAll();
        }
        else
        {
            CloseAll();
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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
            PlayerData.gamePaused = true;
            HideGameBlade();
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

    public void OpenHerbGarden()
    {
        bladeUI.SetActive(true);
        herbsUI.SetActive(true);
    }

    public void OpenFruitOrchard()
    {
        fruitsUI.SetActive(true);
    }

    public void CloseAll()
    {
        PlayerData.gamePaused = false;
        HideUIBlade();
        bladeGame.SetActive(true);
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
        herbsUI.SetActive(false);
        fruitsUI.SetActive(false);
    }

    public void HideGameBlade()
    {
        if (bladeGame.activeSelf)
        {
            bladeGameScript.StopCuttingForUI();
            bladeGame.SetActive(false);
        }
    }

    public void HideUIBlade()
    {
        if (bladeUI.activeSelf)
        {
            bladeUIScript.StopCuttingForUI();
            bladeUI.SetActive(false);
        }
    }
}
