using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemMining : MonoBehaviour
{
    public PlayerData pData;

    public GameObject amber;
    public GameObject quartz;
    public GameObject opal;
    public GameObject jade;
    public GameObject cinnabar;
    public GameObject ametrine;
    public GameObject smokyQuartz;
    public GameObject garnet;
    public GameObject onyx;
    public GameObject pyrite;
    public GameObject heliodor;
    public GameObject citrine;
    public GameObject roseQuartz;
    public GameObject lapisLazuli;
    public GameObject aquamarine;
    public GameObject peridot;
    public GameObject turquoise;
    public GameObject icyQuartz;
    public GameObject coralite;
    public GameObject amethyst;
    public GameObject prismarium;
    public GameObject topaz;
    public GameObject ruby;
    public GameObject moonstone;
    public GameObject sapphire;
    public GameObject sunstone;
    public GameObject emerald;
    public GameObject bloodstone;
    public GameObject starCrystal;
    public GameObject diamond;

    public Image inventoryImage;

    public Text inventoryAmount;

    public int currentGem = 0;

    public void Update()
    {
        DisplayInventoryAmount();
    }

    public void MineGem()
    {
        pData.gems[currentGem].amount++;
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.gems[currentGem].sprite;
        inventoryAmount.text = pData.gems[currentGem].amount.ToString();
    }

    public void UpButton()
    {
        switch (currentGem)
        {
            case 0:
                return;
            case 1:
                amber.SetActive(true);
                quartz.SetActive(false);
                currentGem--;
                break;
            case 2:
                quartz.SetActive(true);
                opal.SetActive(false);
                currentGem--;
                break;
            case 3:
                opal.SetActive(true);
                jade.SetActive(false);
                currentGem--;
                break;
            case 4:
                jade.SetActive(true);
                cinnabar.SetActive(false);
                currentGem--;
                break;
            case 5:
                cinnabar.SetActive(true);
                ametrine.SetActive(false);
                currentGem--;
                break;
            case 6:
                ametrine.SetActive(true);
                smokyQuartz.SetActive(false);
                currentGem--;
                break;
            case 7:
                smokyQuartz.SetActive(true);
                garnet.SetActive(false);
                currentGem--;
                break;
            case 8:
                garnet.SetActive(true);
                onyx.SetActive(false);
                currentGem--;
                break;
            case 9:
                onyx.SetActive(true);
                pyrite.SetActive(false);
                currentGem--;
                break;
            case 10:
                pyrite.SetActive(true);
                heliodor.SetActive(false);
                currentGem--;
                break;
            case 11:
                heliodor.SetActive(true);
                citrine.SetActive(false);
                currentGem--;
                break;
            case 12:
                citrine.SetActive(true);
                roseQuartz.SetActive(false);
                currentGem--;
                break;
            case 13:
                roseQuartz.SetActive(true);
                lapisLazuli.SetActive(false);
                currentGem--;
                break;
            case 14:
                lapisLazuli.SetActive(true);
                aquamarine.SetActive(false);
                currentGem--;
                break;
            case 15:
                aquamarine.SetActive(true);
                peridot.SetActive(false);
                currentGem--;
                break;
            case 16:
                peridot.SetActive(true);
                turquoise.SetActive(false);
                currentGem--;
                break;
            case 17:
                turquoise.SetActive(true);
                icyQuartz.SetActive(false);
                currentGem--;
                break;
            case 18:
                icyQuartz.SetActive(true);
                coralite.SetActive(false);
                currentGem--;
                break;
            case 19:
                coralite.SetActive(true);
                amethyst.SetActive(false);
                currentGem--;
                break;
            case 20:
                amethyst.SetActive(true);
                prismarium.SetActive(false);
                currentGem--;
                break;
            case 21:
                prismarium.SetActive(true);
                topaz.SetActive(false);
                currentGem--;
                break;
            case 22:
                topaz.SetActive(true);
                ruby.SetActive(false);
                currentGem--;
                break;
            case 23:
                ruby.SetActive(true);
                moonstone.SetActive(false);
                currentGem--;
                break;
            case 24:
                moonstone.SetActive(true);
                sapphire.SetActive(false);
                currentGem--;
                break;
            case 25:
                sapphire.SetActive(true);
                sunstone.SetActive(false);
                currentGem--;
                break;
            case 26:
                sunstone.SetActive(true);
                emerald.SetActive(false);
                currentGem--;
                break;
            case 27:
                emerald.SetActive(true);
                bloodstone.SetActive(false);
                currentGem--;
                break;
            case 28:
                bloodstone.SetActive(true);
                starCrystal.SetActive(false);
                currentGem--;
                break;
            case 29:
                starCrystal.SetActive(true);
                diamond.SetActive(false);
                currentGem--;
                break;
            default:
                return;
        }
    }

    public void DownButton()
    {
        switch (currentGem)
        {
            case 0:
                amber.SetActive(false);
                quartz.SetActive(true);
                currentGem++;
                break;
            case 1:
                quartz.SetActive(false);
                opal.SetActive(true);
                currentGem++;
                break;
            case 2:
                opal.SetActive(false);
                jade.SetActive(true);
                currentGem++;
                break;
            case 3:
                jade.SetActive(false);
                cinnabar.SetActive(true);
                currentGem++;
                break;
            case 4:
                cinnabar.SetActive(false);
                ametrine.SetActive(true);
                currentGem++;
                break;
            case 5:
                ametrine.SetActive(false);
                smokyQuartz.SetActive(true);
                currentGem++;
                break;
            case 6:
                smokyQuartz.SetActive(false);
                garnet.SetActive(true);
                currentGem++;
                break;
            case 7:
                garnet.SetActive(false);
                onyx.SetActive(true);
                currentGem++;
                break;
            case 8:
                onyx.SetActive(false);
                pyrite.SetActive(true);
                currentGem++;
                break;
            case 9:
                pyrite.SetActive(false);
                heliodor.SetActive(true);
                currentGem++;
                break;
            case 10:
                heliodor.SetActive(false);
                citrine.SetActive(true);
                currentGem++;
                break;
            case 11:
                citrine.SetActive(false);
                roseQuartz.SetActive(true);
                currentGem++;
                break;
            case 12:
                roseQuartz.SetActive(false);
                lapisLazuli.SetActive(true);
                currentGem++;
                break;
            case 13:
                lapisLazuli.SetActive(false);
                aquamarine.SetActive(true);
                currentGem++;
                break;
            case 14:
                aquamarine.SetActive(false);
                peridot.SetActive(true);
                currentGem++;
                break;
            case 15:
                peridot.SetActive(false);
                turquoise.SetActive(true);
                currentGem++;
                break;
            case 16:
                turquoise.SetActive(false);
                icyQuartz.SetActive(true);
                currentGem++;
                break;
            case 17:
                icyQuartz.SetActive(false);
                coralite.SetActive(true);
                currentGem++;
                break;
            case 18:
                coralite.SetActive(false);
                amethyst.SetActive(true);
                currentGem++;
                break;
            case 19:
                amethyst.SetActive(false);
                prismarium.SetActive(true);
                currentGem++;
                break;
            case 20:
                prismarium.SetActive(false);
                topaz.SetActive(true);
                currentGem++;
                break;
            case 21:
                topaz.SetActive(false);
                ruby.SetActive(true);
                currentGem++;
                break;
            case 22:
                ruby.SetActive(false);
                moonstone.SetActive(true);
                currentGem++;
                break;
            case 23:
                moonstone.SetActive(false);
                sapphire.SetActive(true);
                currentGem++;
                break;
            case 24:
                sapphire.SetActive(false);
                sunstone.SetActive(true);
                currentGem++;
                break;
            case 25:
                sunstone.SetActive(false);
                emerald.SetActive(true);
                currentGem++;
                break;
            case 26:
                emerald.SetActive(false);
                bloodstone.SetActive(true);
                currentGem++;
                break;
            case 27:
                bloodstone.SetActive(false);
                starCrystal.SetActive(true);
                currentGem++;
                break;
            case 28:
                starCrystal.SetActive(false);
                diamond.SetActive(true);
                currentGem++;
                break;
            case 29:
                return;
            default:
                return;
        }
    }
}