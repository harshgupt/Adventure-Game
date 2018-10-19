using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelting : MonoBehaviour {

    public PlayerData pData;

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

    public Text inventoryAmount;

    public int currentMetal = 0;

    public void Update()
    {
        DisplayInventoryAmount();
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.metals[currentMetal].sprite;
        inventoryAmount.text = pData.metals[currentMetal].amount.ToString();
    }

    public void SmeltCopper()
    {
        if(pData.ores[0].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[0].amount++;
            pData.ores[0].amount--;
        }
    }

    public void SmeltTin()
    {
        if (pData.ores[1].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[1].amount++;
            pData.ores[1].amount--;
        }
    }

    public void SmeltBronze()
    {
        if (pData.ores[0].amount == 0 || pData.ores[1].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[2].amount++;
            pData.ores[0].amount--;
            pData.ores[1].amount--;
        }
    }

    public void SmeltIron()
    {
        if (pData.ores[2].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[3].amount++;
            pData.ores[2].amount--;
        }
    }

    public void SmeltSteel()
    {
        if (pData.ores[2].amount == 0 || pData.ores[3].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[4].amount++;
            pData.ores[2].amount--;
            pData.ores[3].amount--;
        }
    }

    public void SmeltAluminium()
    {
        if (pData.ores[4].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[5].amount++;
            pData.ores[4].amount--;
        }
    }

    public void SmeltDuralumin()
    {
        if (pData.ores[0].amount == 0 || pData.ores[4].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[6].amount++;
            pData.ores[0].amount--;
            pData.ores[4].amount--;
        }
    }

    public void SmeltNickel()
    {
        if (pData.ores[5].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[7].amount++;
            pData.ores[5].amount--;
        }
    }

    public void SmeltInvar()
    {
        if (pData.ores[2].amount == 0 || pData.ores[5].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[8].amount++;
            pData.ores[2].amount--;
            pData.ores[5].amount--;
        }
    }

    public void SmeltMagnesium()
    {
        if (pData.ores[6].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[9].amount++;
            pData.ores[6].amount--;
        }
    }

    public void SmeltHydronalium()
    {
        if (pData.ores[4].amount == 0 || pData.ores[6].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[10].amount++;
            pData.ores[4].amount--;
            pData.ores[6].amount--;
        }
    }

    public void SmeltZinc()
    {
        if (pData.ores[7].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[11].amount++;
            pData.ores[7].amount--;
        }
    }

    public void SmeltBrass()
    {
        if (pData.ores[0].amount == 0 || pData.ores[7].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[12].amount++;
            pData.ores[0].amount--;
            pData.ores[7].amount--;
        }
    }

    public void SmeltZamakium()
    {
        if (pData.ores[4].amount == 0 || pData.ores[6].amount == 0 || pData.ores[7].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[13].amount++;
            pData.ores[4].amount--;
            pData.ores[6].amount--;
            pData.ores[7].amount--;
        }
    }

    public void SmeltLead()
    {
        if (pData.ores[8].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[14].amount++;
            pData.ores[8].amount--;
        }
    }

    public void SmeltWhiteMetal()
    {
        if (pData.ores[0].amount == 0 || pData.ores[1].amount == 0 || pData.ores[8].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[15].amount++;
            pData.ores[0].amount--;
            pData.ores[1].amount--;
            pData.ores[8].amount--;
        }
    }

    public void SmeltDamascusSteel()
    {
        if (pData.ores[2].amount == 0 || pData.ores[3].amount == 0 || pData.ores[8].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[16].amount++;
            pData.ores[2].amount--;
            pData.ores[3].amount--;
            pData.ores[8].amount--;
        }
    }

    public void SmeltSilver()
    {
        if (pData.ores[9].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[17].amount++;
            pData.ores[9].amount--;
        }
    }

    public void SmeltGold()
    {
        if (pData.ores[10].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[18].amount++;
            pData.ores[10].amount--;
        }
    }

    public void SmeltRoseGold()
    {
        if (pData.ores[0].amount == 0 || pData.ores[10].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[19].amount++;
            pData.ores[0].amount--;
            pData.ores[10].amount--;
        }
    }

    public void SmeltElinvar()
    {
        if (pData.ores[2].amount == 0 || pData.ores[5].amount == 0 || pData.ores[10].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[20].amount++;
            pData.ores[2].amount--;
            pData.ores[5].amount--;
            pData.ores[10].amount--;
        }
    }

    public void SmeltElectrum()
    {
        if (pData.ores[9].amount == 0 || pData.ores[10].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[21].amount++;
            pData.ores[9].amount--;
            pData.ores[10].amount--;
        }
    }

    public void SmeltCorinthianBronze()
    {
        if (pData.ores[0].amount == 0 || pData.ores[9].amount == 0 || pData.ores[10].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[22].amount++;
            pData.ores[0].amount--;
            pData.ores[9].amount--;
            pData.ores[10].amount--;
        }
    }

    public void SmeltPlatinum()
    {
        if (pData.ores[11].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[23].amount++;
            pData.ores[11].amount--;
        }
    }

    public void SmeltRefinedObsidian()
    {
        if (pData.ores[12].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[24].amount++;
            pData.ores[12].amount--;
        }
    }

    public void SmeltDarksteel()
    {
        if (pData.ores[2].amount == 0 || pData.ores[3].amount == 0 || pData.ores[12].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[25].amount++;
            pData.ores[2].amount--;
            pData.ores[3].amount--;
            pData.ores[12].amount--;
        }
    }

    public void SmeltRefinedMeteorite()
    {
        if (pData.ores[13].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[26].amount++;
            pData.ores[13].amount--;
        }
    }

    public void SmeltMeteoricIron()
    {
        if (pData.ores[2].amount == 0 || pData.ores[3].amount == 0 || pData.ores[13].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[27].amount++;
            pData.ores[2].amount--;
            pData.ores[3].amount--;
            pData.ores[13].amount--;
        }
    }

    public void SmeltShadowsteel()
    {
        if (pData.ores[2].amount == 0 || pData.ores[12].amount == 0 || pData.ores[13].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[28].amount++;
            pData.ores[2].amount--;
            pData.ores[12].amount--;
            pData.ores[13].amount--;
        }
    }

    public void SmeltMeteoricSteel()
    {
        if (pData.ores[11].amount == 0 || pData.ores[12].amount == 0 || pData.ores[13].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[29].amount++;
            pData.ores[11].amount--;
            pData.ores[12].amount--;
            pData.ores[13].amount--;
        }
    }

    public void SmeltMithril()
    {
        if (pData.ores[14].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[30].amount++;
            pData.ores[14].amount--;
        }
    }

    public void SmeltMysticalSteel()
    {
        if (pData.ores[3].amount == 0 || pData.ores[11].amount == 0 || pData.ores[14].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[31].amount++;
            pData.ores[3].amount--;
            pData.ores[11].amount--;
            pData.ores[14].amount--;
        }
    }

    public void SmeltAdamanteus()
    {
        if (pData.ores[15].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[32].amount++;
            pData.ores[15].amount--;
        }
    }

    public void SmeltDivineSteel()
    {
        if (pData.ores[3].amount == 0 || pData.ores[11].amount == 0 || pData.ores[15].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[33].amount++;
            pData.ores[3].amount--;
            pData.ores[11].amount--;
            pData.ores[15].amount--;
        }
    }

    public void SmeltQuicksilver()
    {
        if (pData.ores[16].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[34].amount++;
            pData.ores[16].amount--;
        }
    }

    public void SmeltCelestialSteel()
    {
        if (pData.ores[3].amount == 0 || pData.ores[11].amount == 0 || pData.ores[16].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[35].amount++;
            pData.ores[3].amount--;
            pData.ores[11].amount--;
            pData.ores[16].amount--;
        }
    }

    public void SmeltLuminium()
    {
        if (pData.ores[14].amount == 0 || pData.ores[15].amount == 0 || pData.ores[16].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[36].amount++;
            pData.ores[14].amount--;
            pData.ores[15].amount--;
            pData.ores[16].amount--;
        }
    }

    public void SmeltAether()
    {
        if (pData.ores[17].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[37].amount++;
            pData.ores[17].amount--;
        }
    }

    public void SmeltEtherium()
    {
        if (pData.ores[11].amount == 0 || pData.ores[17].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[38].amount++;
            pData.ores[11].amount--;
            pData.ores[17].amount--;
        }
    }

    public void SmeltCosmicSteel()
    {
        if (pData.ores[3].amount == 0 || pData.ores[11].amount == 0 || pData.ores[17].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[39].amount++;
            pData.ores[3].amount--;
            pData.ores[11].amount--;
            pData.ores[17].amount--;
        }
    }

    public void SmeltCrimsonite()
    {
        if (pData.ores[18].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[40].amount++;
            pData.ores[18].amount--;
        }
    }

    public void SmeltSoulSteel()
    {
        if (pData.ores[12].amount == 0 || pData.ores[13].amount == 0 || pData.ores[18].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[41].amount++;
            pData.ores[12].amount--;
            pData.ores[13].amount--;
            pData.ores[18].amount--;
        }
    }

    public void SmeltNeutronium()
    {
        if (pData.ores[13].amount == 0 || pData.ores[16].amount == 0 || pData.ores[18].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[42].amount++;
            pData.ores[13].amount--;
            pData.ores[16].amount--;
            pData.ores[18].amount--;
        }
    }

    public void SmeltOrichalcum()
    {
        if (pData.ores[16].amount == 0 || pData.ores[17].amount == 0 || pData.ores[18].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[43].amount++;
            pData.ores[16].amount--;
            pData.ores[17].amount--;
            pData.ores[18].amount--;
        }
    }

    public void SmeltInfinitium()
    {
        if (pData.metals[0].amount == 0 || pData.metals[1].amount == 0 || pData.metals[2].amount == 0 || pData.metals[3].amount == 0 || pData.metals[4].amount == 0 || pData.metals[5].amount == 0 || pData.metals[6].amount == 0 || pData.metals[7].amount == 0 || pData.metals[8].amount == 0 || pData.metals[9].amount == 0 || pData.metals[10].amount == 0 || pData.metals[11].amount == 0 || pData.metals[12].amount == 0 || pData.metals[13].amount == 0 || pData.metals[14].amount == 0 || pData.metals[15].amount == 0 || pData.metals[16].amount == 0 || pData.metals[17].amount == 0 || pData.metals[18].amount == 0 || pData.metals[19].amount == 0 || pData.metals[20].amount == 0 || pData.metals[21].amount == 0 || pData.metals[22].amount == 0 || pData.metals[23].amount == 0 || pData.metals[24].amount == 0 || pData.metals[25].amount == 0 || pData.metals[26].amount == 0 || pData.metals[27].amount == 0 || pData.metals[28].amount == 0 || pData.metals[29].amount == 0 || pData.metals[30].amount == 0 || pData.metals[31].amount == 0 || pData.metals[32].amount == 0 || pData.metals[33].amount == 0 || pData.metals[34].amount == 0 || pData.metals[35].amount == 0 || pData.metals[36].amount == 0 || pData.metals[37].amount == 0 || pData.metals[38].amount == 0 || pData.metals[39].amount == 0 || pData.metals[40].amount == 0 || pData.metals[41].amount == 0 || pData.metals[42].amount == 0 || pData.metals[43].amount == 0)
        {
            return;
        }
        else
        {
            pData.metals[44].amount++;
            pData.metals[0].amount--;
            pData.metals[1].amount--;
            pData.metals[2].amount--;
            pData.metals[3].amount--;
            pData.metals[4].amount--;
            pData.metals[5].amount--;
            pData.metals[6].amount--;
            pData.metals[7].amount--;
            pData.metals[8].amount--;
            pData.metals[9].amount--;
            pData.metals[10].amount--;
            pData.metals[11].amount--;
            pData.metals[12].amount--;
            pData.metals[13].amount--;
            pData.metals[14].amount--;
            pData.metals[15].amount--;
            pData.metals[16].amount--;
            pData.metals[17].amount--;
            pData.metals[18].amount--;
            pData.metals[19].amount--;
            pData.metals[20].amount--;
            pData.metals[21].amount--;
            pData.metals[22].amount--;
            pData.metals[23].amount--;
            pData.metals[24].amount--;
            pData.metals[25].amount--;
            pData.metals[26].amount--;
            pData.metals[27].amount--;
            pData.metals[28].amount--;
            pData.metals[29].amount--;
            pData.metals[30].amount--;
            pData.metals[31].amount--;
            pData.metals[32].amount--;
            pData.metals[33].amount--;
            pData.metals[34].amount--;
            pData.metals[35].amount--;
            pData.metals[36].amount--;
            pData.metals[37].amount--;
            pData.metals[38].amount--;
            pData.metals[39].amount--;
            pData.metals[40].amount--;
            pData.metals[41].amount--;
            pData.metals[42].amount--;
            pData.metals[43].amount--;
        }
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
