using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbScript : MonoBehaviour {

    public PlayerData pData;

    private void Awake()
    {
        pData = FindObjectOfType<PlayerData>().GetComponent<PlayerData>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "UI Blade")
        {
            switch (gameObject.name)
            {
                case "Clover":
                    pData.herbs[0].amount++;
                    break;
                case "Daisy Petal":
                    pData.herbs[1].amount++;
                    break;
                case "Holly":
                    pData.herbs[2].amount++;
                    break;
                case "Rose Thorn":
                    pData.herbs[3].amount++;
                    break;
                case "Ivy Sprig":
                    pData.herbs[4].amount++;
                    break;
                case "Windrush":
                    pData.herbs[5].amount++;
                    break;
                case "Willow Twig":
                    pData.herbs[6].amount++;
                    break;
                case "Goosegrass":
                    pData.herbs[7].amount++;
                    break;
                case "Firegrass":
                    pData.herbs[8].amount++;
                    break;
                case "Moly":
                    pData.herbs[9].amount++;
                    break;
                case "Starthistle":
                    pData.herbs[10].amount++;
                    break;
                case "Knotweed":
                    pData.herbs[11].amount++;
                    break;
                case "Bitterroot":
                    pData.herbs[12].amount++;
                    break;
                case "Baneberry":
                    pData.herbs[13].amount++;
                    break;
                case "Mandrake Root":
                    pData.herbs[14].amount++;
                    break;
                case "Tawnymoth Weed":
                    pData.herbs[15].amount++;
                    break;
                case "Spleenwort":
                    pData.herbs[16].amount++;
                    break;
                case "Hellebore Syrup":
                    pData.herbs[17].amount++;
                    break;
                case "Valerian Root":
                    pData.herbs[18].amount++;
                    break;
                case "Dragon Ivy":
                    pData.herbs[19].amount++;
                    break;
                case "Asphodel":
                    pData.herbs[20].amount++;
                    break;
                case "Wormwood":
                    pData.herbs[21].amount++;
                    break;
                case "Silverweed":
                    pData.herbs[22].amount++;
                    break;
                case "Wolfsbane":
                    pData.herbs[23].amount++;
                    break;
                case "Moondew":
                    pData.herbs[24].amount++;
                    break;
                case "Fluxweed":
                    pData.herbs[25].amount++;
                    break;
                case "Tormentil":
                    pData.herbs[26].amount++;
                    break;
                case "Belladonna":
                    pData.herbs[27].amount++;
                    break;
                case "Nightshade":
                    pData.herbs[28].amount++;
                    break;
                case "Bloodroot":
                    pData.herbs[29].amount++;
                    break;
                default:
                    break;
            }
        }
    }
}
