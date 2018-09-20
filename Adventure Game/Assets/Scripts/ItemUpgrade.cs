using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUpgrade : MonoBehaviour {

    public InventoryScript inventoryScript;

    public Text[] armorTierText = new Text[DataManager.numArmour];

    public void Start()
    {
        armorTierText[0].text = PlayerData.armourTier[0].ToString();
        armorTierText[1].text = PlayerData.armourTier[1].ToString();
        armorTierText[2].text = PlayerData.armourTier[2].ToString();
        armorTierText[3].text = PlayerData.armourTier[3].ToString();
        armorTierText[4].text = PlayerData.armourTier[4].ToString();
        armorTierText[5].text = PlayerData.armourTier[5].ToString();
        armorTierText[6].text = PlayerData.armourTier[6].ToString();
        armorTierText[7].text = PlayerData.armourTier[7].ToString();
        armorTierText[8].text = PlayerData.armourTier[8].ToString();
    }

    public void Upgrade(int item)
    {
        switch (PlayerData.armourTier[item])
        {
            case 0:
                if(PlayerData.metals[0] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[0]--;
                    inventoryScript.RemoveItem("Copper", PlayerData.metals[0]);
                }
                break;
            case 1:
                if (PlayerData.metals[1] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[1]--;
                    inventoryScript.RemoveItem("Tin", PlayerData.metals[1]);
                }
                break;
            case 2:
                if (PlayerData.metals[2] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[2]--;
                    inventoryScript.RemoveItem("Bronze", PlayerData.metals[2]);
                }
                break;
            case 3:
                if (PlayerData.metals[3] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[3]--;
                    inventoryScript.RemoveItem("Iron", PlayerData.metals[3]);
                }
                break;
            case 4:
                if (PlayerData.metals[5] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[5]--;
                    inventoryScript.RemoveItem("Lead", PlayerData.metals[5]);
                }
                break;
            case 5:
                if (PlayerData.metals[4] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[4]--;
                    inventoryScript.RemoveItem("Steel", PlayerData.metals[4]);
                }
                break;
            case 6:
                if (PlayerData.metals[6] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[6]--;
                    inventoryScript.RemoveItem("White Metal", PlayerData.metals[6]);
                }
                break;
            case 7:
                if (PlayerData.metals[8] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[8]--;
                    inventoryScript.RemoveItem("Mithril", PlayerData.metals[8]);
                }
                break;
            case 8:
                if (PlayerData.metals[9] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[9]--;
                    inventoryScript.RemoveItem("Adamantine", PlayerData.metals[9]);
                }
                break;
            case 9:
                if (PlayerData.metals[10] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[10]--;
                    inventoryScript.RemoveItem("Quicksilver", PlayerData.metals[10]);
                }
                break;
            case 10:
                if (PlayerData.metals[11] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[11]--;
                    inventoryScript.RemoveItem("Meteorite", PlayerData.metals[11]);
                }
                break;
            case 11:
                if (PlayerData.metals[12] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[12]--;
                    inventoryScript.RemoveItem("Mystical Metal", PlayerData.metals[12]);
                }
                break;
            case 12:
                if (PlayerData.metals[13] == 0)
                {
                    return;
                }
                else
                {
                    PlayerData.armourTier[item]++;
                    PlayerData.metals[13]--;
                    inventoryScript.RemoveItem("Infinitium Metal", PlayerData.metals[13]);
                }
                break;
            default:
                return;
        }
        armorTierText[item].text = PlayerData.armourTier[item].ToString();
    }
}
