using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelting : MonoBehaviour {
    
    public Item[] metals = new Item[13];

    public GameObject copper;
    public GameObject tin;
    public GameObject bronze;
    public GameObject iron;
    public GameObject lead;
    public GameObject steel;
    public GameObject whiteMetal;
    public GameObject blackMetal;
    public GameObject mithril;
    public GameObject adamantine;
    public GameObject quicksilver;
    public GameObject meteorite;
    public GameObject mysticalMetal;
    public GameObject infinitiumMetal;

    public int currentMetal = 0;

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
            PlayerData.metals[5]++;
            PlayerData.ores[2]--;
            PlayerData.ores[3]--;
        }
    }

    public void SmeltLead()
    {
        if (PlayerData.ores[4] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[4]++;
            PlayerData.ores[4]--;
        }
    }

    public void SmeltWhiteMetal()
    {
        if (PlayerData.ores[4] == 0 || PlayerData.ores[1] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[6]++;
            PlayerData.ores[4]--;
            PlayerData.ores[1]--;
        }
    }

    public void SmeltBlackMetal()
    {
        if (PlayerData.ores[4] == 0 || PlayerData.ores[0] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[7]++;
            PlayerData.ores[4]--;
            PlayerData.ores[0]--;
        }
    }

    public void SmeltMithril()
    {
        if (PlayerData.ores[5] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[8]++;
            PlayerData.ores[5]--;
        }
    }

    public void SmeltAdamantine()
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

    public void SmeltQuicksilver()
    {
        if (PlayerData.ores[7] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[10]++;
            PlayerData.ores[7]--;
        }
    }

    public void SmeltMeteorite()
    {
        if (PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[11]++;
            PlayerData.ores[8]--;
        }
    }

    public void SmeltMysticalMetal()
    {
        if (PlayerData.ores[5] == 0 || PlayerData.ores[6] == 0 || PlayerData.ores[7] == 0 || PlayerData.ores[8] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[12]++;
            PlayerData.ores[5]--;
            PlayerData.ores[6]--;
            PlayerData.ores[7]--;
            PlayerData.ores[8]--;
        }
    }

    public void SmeltInfinitiumMetal()
    {
        if (PlayerData.metals[0] == 0 || PlayerData.metals[1] == 0 || PlayerData.metals[2] == 0 || PlayerData.metals[3] == 0 || PlayerData.metals[4] == 0 || PlayerData.metals[5] == 0 || PlayerData.metals[6] == 0 || PlayerData.metals[7] == 0 || PlayerData.metals[8] == 0 || PlayerData.metals[9] == 0 || PlayerData.metals[10] == 0 || PlayerData.metals[11] == 0 || PlayerData.metals[12] == 0)
        {
            return;
        }
        else
        {
            PlayerData.metals[13]++;
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
        }
    }

    public void UpButton()
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
                lead.SetActive(false);
                currentMetal--;
                break;
            case 5:
                lead.SetActive(true);
                steel.SetActive(false);
                currentMetal--;
                break;
            case 6:
                steel.SetActive(true);
                whiteMetal.SetActive(false);
                currentMetal--;
                break;
            case 7:
                whiteMetal.SetActive(true);
                blackMetal.SetActive(false);
                currentMetal--;
                break;
            case 8:
                blackMetal.SetActive(true);
                mithril.SetActive(false);
                currentMetal--;
                break;
            case 9:
                mithril.SetActive(true);
                adamantine.SetActive(false);
                currentMetal--;
                break;
            case 10:
                adamantine.SetActive(true);
                quicksilver.SetActive(false);
                currentMetal--;
                break;
            case 11:
                quicksilver.SetActive(true);
                meteorite.SetActive(false);
                currentMetal--;
                break;
            case 12:
                meteorite.SetActive(true);
                mysticalMetal.SetActive(false);
                currentMetal--;
                break;
            case 13:
                mysticalMetal.SetActive(true);
                infinitiumMetal.SetActive(false);
                currentMetal--;
                break;
            default:
                return;
        }
    }

    public void DownButton()
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
                lead.SetActive(true);
                currentMetal++;
                break;
            case 4:
                lead.SetActive(false);
                steel.SetActive(true);
                currentMetal++;
                break;
            case 5:
                steel.SetActive(false);
                whiteMetal.SetActive(true);
                currentMetal++;
                break;
            case 6:
                whiteMetal.SetActive(false);
                blackMetal.SetActive(true);
                currentMetal++;
                break;
            case 7:
                blackMetal.SetActive(false);
                mithril.SetActive(true);
                currentMetal++;
                break;
            case 8:
                mithril.SetActive(false);
                adamantine.SetActive(true);
                currentMetal++;
                break;
            case 9:
                adamantine.SetActive(false);
                quicksilver.SetActive(true);
                currentMetal++;
                break;
            case 10:
                quicksilver.SetActive(false);
                meteorite.SetActive(true);
                currentMetal++;
                break;
            case 11:
                meteorite.SetActive(false);
                mysticalMetal.SetActive(true);
                currentMetal++;
                break;
            case 12:
                mysticalMetal.SetActive(false);
                infinitiumMetal.SetActive(true);
                currentMetal++;
                break;
            case 13:
                return;
            default:
                return;
        }
    }
}
