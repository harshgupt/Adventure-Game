using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelting : MonoBehaviour {

    public GameObject copper;
    public GameObject tin;
    public GameObject bronze;
    public GameObject iron;
    public GameObject steel;
    public GameObject aluminium;
    public GameObject duralumin;
    public GameObject nickel;
    public GameObject invar;
    public GameObject magnesium;
    public GameObject hydronalium;
    public GameObject zinc;
    public GameObject brass;
    public GameObject zamakium;
    public GameObject lead;
    public GameObject whiteMetal;
    public GameObject damascusSteel;
    public GameObject silver;
    public GameObject gold;
    public GameObject roseGold;
    public GameObject elinvar;
    public GameObject electrum;
    public GameObject corinthianBronze;
    public GameObject platinum;
    public GameObject refinedObsidian;
    public GameObject darksteel;
    public GameObject refinedMeteorite;
    public GameObject meteoricIron;
    public GameObject shadowsteel;
    public GameObject meteoricSteel;
    public GameObject mithril;
    public GameObject mysticalSteel;
    public GameObject adamanteus;
    public GameObject divineSteel;
    public GameObject quicksilver;
    public GameObject celestialSteel;
    public GameObject luminium;
    public GameObject aether;
    public GameObject etherium;
    public GameObject cosmicSteel;
    public GameObject crimsonite;
    public GameObject soulSteel;
    public GameObject neutronium;
    public GameObject orichalcum;
    public GameObject infinitium;

    public Image inventoryImage;

    public Sprite[] metalSprites = new Sprite[DataManager.numMetals];

    public Text inventoryAmount;

    public int currentMetal = 0;

    public void Update()
    {
        DisplayInventoryAmount();
    }

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
        }
    }

    public void SmeltAluminium()
    {
        if (PlayerData.ores[4] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[5]++;
            PlayerData.ores[4]--;
        }
    }

    public void SmeltDuralumin()
    {
        if (PlayerData.ores[0] == 0 || PlayerData.ores[4] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[6]++;
            PlayerData.ores[0]--;
            PlayerData.ores[4]--;
        }
    }

    public void SmeltNickel()
    {
        if (PlayerData.ores[5] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[7]++;
            PlayerData.ores[5]--;
        }
    }

    public void SmeltInvar()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[5] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[8]++;
            PlayerData.ores[2]--;
            PlayerData.ores[5]--;
        }
    }

    public void SmeltMagnesium()
    {
        if (PlayerData.ores[6] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[9]++;
            PlayerData.ores[6]--;
        }
    }

    public void SmeltHydronalium()
    {
        if (PlayerData.ores[4] == 0 || PlayerData.ores[6] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[10]++;
            PlayerData.ores[4]--;
            PlayerData.ores[6]--;
        }
    }

    public void SmeltZinc()
    {
        if (PlayerData.ores[7] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[11]++;
            PlayerData.ores[7]--;
        }
    }

    public void SmeltBrass()
    {
        if (PlayerData.ores[0] == 0 || PlayerData.ores[7] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[12]++;
            PlayerData.ores[0]--;
            PlayerData.ores[7]--;
        }
    }

    public void SmeltZamakium()
    {
        if (PlayerData.ores[4] == 0 || PlayerData.ores[6] == 0 || PlayerData.ores[7] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[13]++;
            PlayerData.ores[4]--;
            PlayerData.ores[6]--;
            PlayerData.ores[7]--;
        }
    }

    public void SmeltLead()
    {
        if (PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[14]++;
            PlayerData.ores[8]--;
        }
    }

    public void SmeltWhiteMetal()
    {
        if (PlayerData.ores[0] == 0 || PlayerData.ores[1] == 0 || PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[15]++;
            PlayerData.ores[0]--;
            PlayerData.ores[1]--;
            PlayerData.ores[8]--;
        }
    }

    public void SmeltDamascusSteel()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[3] == 0 || PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[16]++;
            PlayerData.ores[2]--;
            PlayerData.ores[3]--;
            PlayerData.ores[8]--;
        }
    }

    public void SmeltSilver()
    {
        if (PlayerData.ores[9] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[17]++;
            PlayerData.ores[9]--;
        }
    }

    public void SmeltGold()
    {
        if (PlayerData.ores[10] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[18]++;
            PlayerData.ores[10]--;
        }
    }

    public void SmeltRoseGold()
    {
        if (PlayerData.ores[0] == 0 || PlayerData.ores[10] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[19]++;
            PlayerData.ores[0]--;
            PlayerData.ores[10]--;
        }
    }

    public void SmeltElinvar()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[5] == 0 || PlayerData.ores[10] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[20]++;
            PlayerData.ores[2]--;
            PlayerData.ores[5]--;
            PlayerData.ores[10]--;
        }
    }

    public void SmeltElectrum()
    {
        if (PlayerData.ores[9] == 0 || PlayerData.ores[10] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[21]++;
            PlayerData.ores[9]--;
            PlayerData.ores[10]--;
        }
    }

    public void SmeltCorinthianBronze()
    {
        if (PlayerData.ores[0] == 0 || PlayerData.ores[9] == 0 || PlayerData.ores[10] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[22]++;
            PlayerData.ores[0]--;
            PlayerData.ores[9]--;
            PlayerData.ores[10]--;
        }
    }

    public void SmeltPlatinum()
    {
        if (PlayerData.ores[11] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[23]++;
            PlayerData.ores[11]--;
        }
    }

    public void SmeltRefinedObsidian()
    {
        if (PlayerData.ores[12] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[24]++;
            PlayerData.ores[12]--;
        }
    }

    public void SmeltDarksteel()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[3] == 0 || PlayerData.ores[12] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[25]++;
            PlayerData.ores[2]--;
            PlayerData.ores[3]--;
            PlayerData.ores[12]--;
        }
    }

    public void SmeltRefinedMeteorite()
    {
        if (PlayerData.ores[13] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[26]++;
            PlayerData.ores[13]--;
        }
    }

    public void SmeltMeteoricIron()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[3] == 0 || PlayerData.ores[13] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[27]++;
            PlayerData.ores[2]--;
            PlayerData.ores[3]--;
            PlayerData.ores[13]--;
        }
    }

    public void SmeltShadowsteel()
    {
        if (PlayerData.ores[2] == 0 || PlayerData.ores[12] == 0 || PlayerData.ores[13] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[28]++;
            PlayerData.ores[2]--;
            PlayerData.ores[12]--;
            PlayerData.ores[13]--;
        }
    }

    public void SmeltMeteoricSteel()
    {
        if (PlayerData.ores[11] == 0 || PlayerData.ores[12] == 0 || PlayerData.ores[13] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[29]++;
            PlayerData.ores[11]--;
            PlayerData.ores[12]--;
            PlayerData.ores[13]--;
        }
    }

    public void SmeltMithril()
    {
        if (PlayerData.ores[14] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[30]++;
            PlayerData.ores[14]--;
        }
    }

    public void SmeltMysticalSteel()
    {
        if (PlayerData.ores[3] == 0 || PlayerData.ores[11] == 0 || PlayerData.ores[14] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[31]++;
            PlayerData.ores[3]--;
            PlayerData.ores[11]--;
            PlayerData.ores[14]--;
        }
    }

    public void SmeltAdamanteus()
    {
        if (PlayerData.ores[15] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[32]++;
            PlayerData.ores[15]--;
        }
    }

    public void SmeltDivineSteel()
    {
        if (PlayerData.ores[3] == 0 || PlayerData.ores[11] == 0 || PlayerData.ores[15] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[33]++;
            PlayerData.ores[3]--;
            PlayerData.ores[11]--;
            PlayerData.ores[15]--;
        }
    }

    public void SmeltQuicksilver()
    {
        if (PlayerData.ores[16] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[34]++;
            PlayerData.ores[16]--;
        }
    }

    public void SmeltCelestialSteel()
    {
        if (PlayerData.ores[3] == 0 || PlayerData.ores[11] == 0 || PlayerData.ores[16] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[35]++;
            PlayerData.ores[3]--;
            PlayerData.ores[11]--;
            PlayerData.ores[16]--;
        }
    }

    public void SmeltLuminium()
    {
        if (PlayerData.ores[14] == 0 || PlayerData.ores[15] == 0 || PlayerData.ores[16] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[36]++;
            PlayerData.ores[14]--;
            PlayerData.ores[15]--;
            PlayerData.ores[16]--;
        }
    }

    public void SmeltAether()
    {
        if (PlayerData.ores[17] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[37]++;
            PlayerData.ores[17]--;
        }
    }

    public void SmeltEtherium()
    {
        if (PlayerData.ores[11] == 0 || PlayerData.ores[17] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[38]++;
            PlayerData.ores[11]--;
            PlayerData.ores[17]--;
        }
    }

    public void SmeltCosmicSteel()
    {
        if (PlayerData.ores[3] == 0 || PlayerData.ores[11] == 0 || PlayerData.ores[17] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[39]++;
            PlayerData.ores[3]--;
            PlayerData.ores[11]--;
            PlayerData.ores[17]--;
        }
    }

    public void SmeltCrimsonite()
    {
        if (PlayerData.ores[18] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[40]++;
            PlayerData.ores[18]--;
        }
    }

    public void SmeltSoulSteel()
    {
        if (PlayerData.ores[12] == 0 || PlayerData.ores[13] == 0 || PlayerData.ores[18] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[41]++;
            PlayerData.ores[12]--;
            PlayerData.ores[13]--;
            PlayerData.ores[18]--;
        }
    }

    public void SmeltNeutronium()
    {
        if (PlayerData.ores[13] == 0 || PlayerData.ores[16] == 0 || PlayerData.ores[18] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[42]++;
            PlayerData.ores[13]--;
            PlayerData.ores[16]--;
            PlayerData.ores[18]--;
        }
    }

    public void SmeltOrichalcum()
    {
        if (PlayerData.ores[16] == 0 || PlayerData.ores[17] == 0 || PlayerData.ores[18] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[43]++;
            PlayerData.ores[16]--;
            PlayerData.ores[17]--;
            PlayerData.ores[18]--;
        }
    }

    public void SmeltInfinitium()
    {
        if (PlayerData.metals[0] == 0 || PlayerData.metals[1] == 0 || PlayerData.metals[2] == 0 || PlayerData.metals[3] == 0 || PlayerData.metals[4] == 0 || PlayerData.metals[5] == 0 || PlayerData.metals[6] == 0 || PlayerData.metals[7] == 0 || PlayerData.metals[8] == 0 || PlayerData.metals[9] == 0 || PlayerData.metals[10] == 0 || PlayerData.metals[11] == 0 || PlayerData.metals[12] == 0 || PlayerData.metals[13] == 0 || PlayerData.metals[14] == 0 || PlayerData.metals[15] == 0 || PlayerData.metals[16] == 0 || PlayerData.metals[17] == 0 || PlayerData.metals[18] == 0 || PlayerData.metals[19] == 0 || PlayerData.metals[20] == 0 || PlayerData.metals[21] == 0 || PlayerData.metals[22] == 0 || PlayerData.metals[23] == 0 || PlayerData.metals[24] == 0 || PlayerData.metals[25] == 0 || PlayerData.metals[26] == 0 || PlayerData.metals[27] == 0 || PlayerData.metals[28] == 0 || PlayerData.metals[29] == 0 || PlayerData.metals[30] == 0 || PlayerData.metals[31] == 0 || PlayerData.metals[32] == 0 || PlayerData.metals[33] == 0 || PlayerData.metals[34] == 0 || PlayerData.metals[35] == 0 || PlayerData.metals[36] == 0 || PlayerData.metals[37] == 0 || PlayerData.metals[38] == 0 || PlayerData.metals[39] == 0 || PlayerData.metals[40] == 0 || PlayerData.metals[41] == 0 || PlayerData.metals[42] == 0 || PlayerData.metals[43] == 0 || PlayerData.metals[44] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[44]++;
            PlayerData.metals[0]--;
            PlayerData.metals[1]--;
            PlayerData.metals[2]--;
            PlayerData.metals[3]--;
            PlayerData.metals[4]--;
            PlayerData.metals[5]--;
            PlayerData.metals[6]--;
            PlayerData.metals[7]--;
            PlayerData.metals[8]--;
            PlayerData.metals[9]--;
            PlayerData.metals[10]--;
            PlayerData.metals[11]--;
            PlayerData.metals[12]--;
            PlayerData.metals[13]--;
            PlayerData.metals[14]--;
            PlayerData.metals[15]--;
            PlayerData.metals[16]--;
            PlayerData.metals[17]--;
            PlayerData.metals[18]--;
            PlayerData.metals[19]--;
            PlayerData.metals[20]--;
            PlayerData.metals[21]--;
            PlayerData.metals[22]--;
            PlayerData.metals[23]--;
            PlayerData.metals[24]--;
            PlayerData.metals[25]--;
            PlayerData.metals[26]--;
            PlayerData.metals[27]--;
            PlayerData.metals[28]--;
            PlayerData.metals[29]--;
            PlayerData.metals[30]--;
            PlayerData.metals[31]--;
            PlayerData.metals[32]--;
            PlayerData.metals[33]--;
            PlayerData.metals[34]--;
            PlayerData.metals[35]--;
            PlayerData.metals[36]--;
            PlayerData.metals[37]--;
            PlayerData.metals[38]--;
            PlayerData.metals[39]--;
            PlayerData.metals[40]--;
            PlayerData.metals[41]--;
            PlayerData.metals[42]--;
            PlayerData.metals[43]--;
        }
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = metalSprites[currentMetal];
        inventoryAmount.text = PlayerData.metals[currentMetal].ToString();
    }

    public void LeftButton()
    {
        switch (currentMetal)
        {
            case 0:
                return;
            case 1:
                copper.SetActive(true);
                tin.SetActive(false);
                currentMetal--;
                break;
            case 2:
                tin.SetActive(true);
                bronze.SetActive(false);
                currentMetal--;
                break;
            case 3:
                bronze.SetActive(true);
                iron.SetActive(false);
                currentMetal--;
                break;
            case 4:
                iron.SetActive(true);
                steel.SetActive(false);
                currentMetal--;
                break;
            case 5:
                steel.SetActive(true);
                aluminium.SetActive(false);
                currentMetal--;
                break;
            case 6:
                aluminium.SetActive(true);
                duralumin.SetActive(false);
                currentMetal--;
                break;
            case 7:
                duralumin.SetActive(true);
                nickel.SetActive(false);
                currentMetal--;
                break;
            case 8:
                nickel.SetActive(true);
                invar.SetActive(false);
                currentMetal--;
                break;
            case 9:
                invar.SetActive(true);
                magnesium.SetActive(false);
                currentMetal--;
                break;
            case 10:
                magnesium.SetActive(true);
                hydronalium.SetActive(false);
                currentMetal--;
                break;
            case 11:
                hydronalium.SetActive(true);
                zinc.SetActive(false);
                currentMetal--;
                break;
            case 12:
                zinc.SetActive(true);
                brass.SetActive(false);
                currentMetal--;
                break;
            case 13:
                brass.SetActive(true);
                zamakium.SetActive(false);
                currentMetal--;
                break;
            case 14:
                zamakium.SetActive(true);
                lead.SetActive(false);
                currentMetal--;
                break;
            case 15:
                lead.SetActive(true);
                whiteMetal.SetActive(false);
                currentMetal--;
                break;
            case 16:
                whiteMetal.SetActive(true);
                damascusSteel.SetActive(false);
                currentMetal--;
                break;
            case 17:
                damascusSteel.SetActive(true);
                silver.SetActive(false);
                currentMetal--;
                break;
            case 18:
                silver.SetActive(true);
                gold.SetActive(false);
                currentMetal--;
                break;
            case 19:
                gold.SetActive(true);
                roseGold.SetActive(false);
                currentMetal--;
                break;
            case 20:
                roseGold.SetActive(true);
                elinvar.SetActive(false);
                currentMetal--;
                break;
            case 21:
                elinvar.SetActive(true);
                electrum.SetActive(false);
                currentMetal--;
                break;
            case 22:
                electrum.SetActive(true);
                corinthianBronze.SetActive(false);
                currentMetal--;
                break;
            case 23:
                corinthianBronze.SetActive(true);
                platinum.SetActive(false);
                currentMetal--;
                break;
            case 24:
                platinum.SetActive(true);
                refinedObsidian.SetActive(false);
                currentMetal--;
                break;
            case 25:
                refinedObsidian.SetActive(true);
                darksteel.SetActive(false);
                currentMetal--;
                break;
            case 26:
                darksteel.SetActive(true);
                refinedMeteorite.SetActive(false);
                currentMetal--;
                break;
            case 27:
                refinedMeteorite.SetActive(true);
                meteoricIron.SetActive(false);
                currentMetal--;
                break;
            case 28:
                meteoricIron.SetActive(true);
                shadowsteel.SetActive(false);
                currentMetal--;
                break;
            case 29:
                shadowsteel.SetActive(true);
                meteoricSteel.SetActive(false);
                currentMetal--;
                break;
            case 30:
                meteoricSteel.SetActive(true);
                mithril.SetActive(false);
                currentMetal--;
                break;
            case 31:
                mithril.SetActive(true);
                mysticalSteel.SetActive(false);
                currentMetal--;
                break;
            case 32:
                mysticalSteel.SetActive(true);
                adamanteus.SetActive(false);
                currentMetal--;
                break;
            case 33:
                adamanteus.SetActive(true);
                divineSteel.SetActive(false);
                currentMetal--;
                break;
            case 34:
                divineSteel.SetActive(true);
                quicksilver.SetActive(false);
                currentMetal--;
                break;
            case 35:
                quicksilver.SetActive(true);
                celestialSteel.SetActive(false);
                currentMetal--;
                break;
            case 36:
                celestialSteel.SetActive(true);
                luminium.SetActive(false);
                currentMetal--;
                break;
            case 37:
                luminium.SetActive(true);
                aether.SetActive(false);
                currentMetal--;
                break;
            case 38:
                aether.SetActive(true);
                etherium.SetActive(false);
                currentMetal--;
                break;
            case 39:
                etherium.SetActive(true);
                cosmicSteel.SetActive(false);
                currentMetal--;
                break;
            case 40:
                cosmicSteel.SetActive(true);
                crimsonite.SetActive(false);
                currentMetal--;
                break;
            case 41:
                crimsonite.SetActive(true);
                soulSteel.SetActive(false);
                currentMetal--;
                break;
            case 42:
                soulSteel.SetActive(true);
                neutronium.SetActive(false);
                currentMetal--;
                break;
            case 43:
                neutronium.SetActive(true);
                orichalcum.SetActive(false);
                currentMetal--;
                break;
            case 44:
                orichalcum.SetActive(true);
                infinitium.SetActive(false);
                currentMetal--;
                break;
            default:
                return;
        }
    }

    public void RightButton()
    {
        switch (currentMetal)
        {
            case 0:
                copper.SetActive(false);
                tin.SetActive(true);
                currentMetal++;
                break;
            case 1:
                tin.SetActive(false);
                bronze.SetActive(true);
                currentMetal++;
                break;
            case 2:
                bronze.SetActive(false);
                iron.SetActive(true);
                currentMetal++;
                break;
            case 3:
                iron.SetActive(false);
                steel.SetActive(true);
                currentMetal++;
                break;
            case 4:
                steel.SetActive(false);
                aluminium.SetActive(true);
                currentMetal++;
                break;
            case 5:
                aluminium.SetActive(false);
                duralumin.SetActive(true);
                currentMetal++;
                break;
            case 6:
                duralumin.SetActive(false);
                nickel.SetActive(true);
                currentMetal++;
                break;
            case 7:
                nickel.SetActive(false);
                invar.SetActive(true);
                currentMetal++;
                break;
            case 8:
                invar.SetActive(false);
                magnesium.SetActive(true);
                currentMetal++;
                break;
            case 9:
                magnesium.SetActive(false);
                hydronalium.SetActive(true);
                currentMetal++;
                break;
            case 10:
                hydronalium.SetActive(false);
                zinc.SetActive(true);
                currentMetal++;
                break;
            case 11:
                zinc.SetActive(false);
                brass.SetActive(true);
                currentMetal++;
                break;
            case 12:
                brass.SetActive(false);
                zamakium.SetActive(true);
                currentMetal++;
                break;
            case 13:
                zamakium.SetActive(false);
                lead.SetActive(true);
                currentMetal++;
                break;
            case 14:
                lead.SetActive(false);
                whiteMetal.SetActive(true);
                currentMetal++;
                break;
            case 15:
                whiteMetal.SetActive(false);
                damascusSteel.SetActive(true);
                currentMetal++;
                break;
            case 16:
                damascusSteel.SetActive(false);
                silver.SetActive(true);
                currentMetal++;
                break;
            case 17:
                silver.SetActive(false);
                gold.SetActive(true);
                currentMetal++;
                break;
            case 18:
                gold.SetActive(false);
                roseGold.SetActive(true);
                currentMetal++;
                break;
            case 19:
                roseGold.SetActive(false);
                elinvar.SetActive(true);
                currentMetal++;
                break;
            case 20:
                elinvar.SetActive(false);
                electrum.SetActive(true);
                currentMetal++;
                break;
            case 21:
                electrum.SetActive(false);
                corinthianBronze.SetActive(true);
                currentMetal++;
                break;
            case 22:
                corinthianBronze.SetActive(false);
                platinum.SetActive(true);
                currentMetal++;
                break;
            case 23:
                platinum.SetActive(false);
                refinedObsidian.SetActive(true);
                currentMetal++;
                break;
            case 24:
                refinedObsidian.SetActive(false);
                darksteel.SetActive(true);
                currentMetal++;
                break;
            case 25:
                darksteel.SetActive(false);
                refinedMeteorite.SetActive(true);
                currentMetal++;
                break;
            case 26:
                refinedMeteorite.SetActive(false);
                meteoricIron.SetActive(true);
                currentMetal++;
                break;
            case 27:
                meteoricIron.SetActive(false);
                shadowsteel.SetActive(true);
                currentMetal++;
                break;
            case 28:
                shadowsteel.SetActive(false);
                meteoricSteel.SetActive(true);
                currentMetal++;
                break;
            case 29:
                meteoricSteel.SetActive(false);
                mithril.SetActive(true);
                currentMetal++;
                break;
            case 30:
                mithril.SetActive(false);
                mysticalSteel.SetActive(true);
                currentMetal++;
                break;
            case 31:
                mysticalSteel.SetActive(false);
                adamanteus.SetActive(true);
                currentMetal++;
                break;
            case 32:
                adamanteus.SetActive(false);
                divineSteel.SetActive(true);
                currentMetal++;
                break;
            case 33:
                divineSteel.SetActive(false);
                quicksilver.SetActive(true);
                currentMetal++;
                break;
            case 34:
                quicksilver.SetActive(false);
                celestialSteel.SetActive(true);
                currentMetal++;
                break;
            case 35:
                celestialSteel.SetActive(false);
                luminium.SetActive(true);
                currentMetal++;
                break;
            case 36:
                luminium.SetActive(false);
                aether.SetActive(true);
                currentMetal++;
                break;
            case 37:
                aether.SetActive(false);
                etherium.SetActive(true);
                currentMetal++;
                break;
            case 38:
                etherium.SetActive(false);
                cosmicSteel.SetActive(true);
                currentMetal++;
                break;
            case 39:
                cosmicSteel.SetActive(false);
                crimsonite.SetActive(true);
                currentMetal++;
                break;
            case 40:
                crimsonite.SetActive(false);
                soulSteel.SetActive(true);
                currentMetal++;
                break;
            case 41:
                soulSteel.SetActive(false);
                neutronium.SetActive(true);
                currentMetal++;
                break;
            case 42:
                neutronium.SetActive(false);
                orichalcum.SetActive(true);
                currentMetal++;
                break;
            case 43:
                orichalcum.SetActive(false);
                infinitium.SetActive(true);
                currentMetal++;
                break;
            case 44:
                return;
            default:
                return;
        }
    }
}
