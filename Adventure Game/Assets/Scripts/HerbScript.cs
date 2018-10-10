using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbScript : MonoBehaviour {
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "UI Blade")
        {
            switch (gameObject.name)
            {
                case "Clover":
                    PlayerData.herbs[0]++;
                    break;
                case "Daisy Petal":
                    PlayerData.herbs[1]++;
                    break;
                case "Holly":
                    PlayerData.herbs[2]++;
                    break;
                case "Rose Thorn":
                    PlayerData.herbs[3]++;
                    break;
                case "Ivy Sprig":
                    PlayerData.herbs[4]++;
                    break;
                case "Windrush":
                    PlayerData.herbs[5]++;
                    break;
                case "Willow Twig":
                    PlayerData.herbs[6]++;
                    break;
                case "Goosegrass":
                    PlayerData.herbs[7]++;
                    break;
                case "Firegrass":
                    PlayerData.herbs[8]++;
                    break;
                case "Moly":
                    PlayerData.herbs[9]++;
                    break;
                case "Starthistle":
                    PlayerData.herbs[10]++;
                    break;
                case "Knotweed":
                    PlayerData.herbs[11]++;
                    break;
                case "Bitterroot":
                    PlayerData.herbs[12]++;
                    break;
                case "Baneberry":
                    PlayerData.herbs[13]++;
                    break;
                case "Mandrake Root":
                    PlayerData.herbs[14]++;
                    break;
                case "Tawnymoth Weed":
                    PlayerData.herbs[15]++;
                    break;
                case "Spleenwort":
                    PlayerData.herbs[16]++;
                    break;
                case "Hellebore Syrup":
                    PlayerData.herbs[17]++;
                    break;
                case "Valerian Root":
                    PlayerData.herbs[18]++;
                    break;
                case "Dragon Ivy":
                    PlayerData.herbs[19]++;
                    break;
                case "Asphodel":
                    PlayerData.herbs[20]++;
                    break;
                case "Wormwood":
                    PlayerData.herbs[21]++;
                    break;
                case "Silverweed":
                    PlayerData.herbs[22]++;
                    break;
                case "Wolfsbane":
                    PlayerData.herbs[23]++;
                    break;
                case "Moondew":
                    PlayerData.herbs[24]++;
                    break;
                case "Fluxweed":
                    PlayerData.herbs[25]++;
                    break;
                case "Tormentil":
                    PlayerData.herbs[26]++;
                    break;
                case "Belladonna":
                    PlayerData.herbs[27]++;
                    break;
                case "Nightshade":
                    PlayerData.herbs[28]++;
                    break;
                case "Bloodroot":
                    PlayerData.herbs[29]++;
                    break;
                default:
                    break;
            }
        }
    }
}
