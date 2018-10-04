using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour {
    
    public Item[] ores = new Item[9];

    public GameObject copperOre;
    public GameObject tinOre;
    public GameObject ironOre;
    public GameObject coalOre;
    public GameObject leadOre;
    public GameObject mithrilOre;
    public GameObject adamantineOre;
    public GameObject quicksilverOre;
    public GameObject meteoriteOre;

    public int currentOre = 0;

    public void CopperMine()
    {
        PlayerData.ores[0]++;
    }

    public void TinMine()
    {
        PlayerData.ores[1]++;
    }

    public void IronMine()
    {
        PlayerData.ores[2]++;
    }

    public void CoalMine()
    {
        PlayerData.ores[3]++;
    }

    public void LeadMine()
    {
        PlayerData.ores[4]++;
    }

    public void MithrilMine()
    {
        PlayerData.ores[5]++;
    }

    public void AdamantineMine()
    {
        PlayerData.ores[6]++;
    }

    public void QuicksilverMine()
    {
        PlayerData.ores[7]++;
    }

    public void MeteoriteMine()
    {
        PlayerData.ores[8]++;
    }

    public void UpButton()
    {
        switch (currentOre)
        {
            case 0:
                return;
            case 1:
                copperOre.SetActive(true);
                tinOre.SetActive(false);
                currentOre--;
                break;
            case 2:
                tinOre.SetActive(true);
                ironOre.SetActive(false);
                currentOre--;
                break;
            case 3:
                ironOre.SetActive(true);
                coalOre.SetActive(false);
                currentOre--;
                break;
            case 4:
                coalOre.SetActive(true);
                leadOre.SetActive(false);
                currentOre--;
                break;
            case 5:
                leadOre.SetActive(true);
                mithrilOre.SetActive(false);
                currentOre--;
                break;
            case 6:
                mithrilOre.SetActive(true);
                adamantineOre.SetActive(false);
                currentOre--;
                break;
            case 7:
                adamantineOre.SetActive(true);
                quicksilverOre.SetActive(false);
                currentOre--;
                break;
            case 8:
                quicksilverOre.SetActive(true);
                meteoriteOre.SetActive(false);
                currentOre--;
                break;
            default:
                return;
        }
    }

    public void DownButton()
    {
        switch (currentOre)
        {
            case 0:
                copperOre.SetActive(false);
                tinOre.SetActive(true);
                currentOre++;
                break;
            case 1:
                tinOre.SetActive(false);
                ironOre.SetActive(true);
                currentOre++;
                break;
            case 2:
                ironOre.SetActive(false);
                coalOre.SetActive(true);
                currentOre++;
                break;
            case 3:
                coalOre.SetActive(false);
                leadOre.SetActive(true);
                currentOre++;
                break;
            case 4:
                leadOre.SetActive(false);
                mithrilOre.SetActive(true);
                currentOre++;
                break;
            case 5:
                mithrilOre.SetActive(false);
                adamantineOre.SetActive(true);
                currentOre++;
                break;
            case 6:
                adamantineOre.SetActive(false);
                quicksilverOre.SetActive(true);
                currentOre++;
                break;
            case 7:
                quicksilverOre.SetActive(false);
                meteoriteOre.SetActive(true);
                currentOre++;
                break;
            case 8:
                return;
            default:
                return;
        }
    }
}