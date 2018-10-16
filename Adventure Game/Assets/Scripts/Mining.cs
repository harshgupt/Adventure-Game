using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour {

    public GameObject copperOre;
    public GameObject tinOre;
    public GameObject ironOre;
    public GameObject coalOre;
    public GameObject aluminiumOre;
    public GameObject nickelOre;
    public GameObject magnesiumOre;
    public GameObject zincOre;
    public GameObject leadOre;
    public GameObject silverOre;
    public GameObject goldOre;
    public GameObject platinumOre;
    public GameObject obsidianOre;
    public GameObject meteoriteOre;
    public GameObject mithrilOre;
    public GameObject adamanteusOre;
    public GameObject quicksilverOre;
    public GameObject aetherOre;
    public GameObject crimsoniteOre;

    public Image inventoryImage;

    public Sprite[] oreSprites = new Sprite[DataManager.numOres];

    public Text inventoryAmount;

    public int currentOre = 0;

    public void Update()
    {
        DisplayInventoryAmount();
    }

    public void MineOre()
    {
        PlayerData.ores[currentOre]++;
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = oreSprites[currentOre];
        inventoryAmount.text = PlayerData.ores[currentOre].ToString();
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
                aluminiumOre.SetActive(false);
                currentOre--;
                break;
            case 5:
                aluminiumOre.SetActive(true);
                nickelOre.SetActive(false);
                currentOre--;
                break;
            case 6:
                nickelOre.SetActive(true);
                magnesiumOre.SetActive(false);
                currentOre--;
                break;
            case 7:
                magnesiumOre.SetActive(true);
                zincOre.SetActive(false);
                currentOre--;
                break;
            case 8:
                zincOre.SetActive(true);
                leadOre.SetActive(false);
                currentOre--;
                break;
            case 9:
                leadOre.SetActive(true);
                silverOre.SetActive(false);
                currentOre--;
                break;
            case 10:
                silverOre.SetActive(true);
                goldOre.SetActive(false);
                currentOre--;
                break;
            case 11:
                goldOre.SetActive(true);
                platinumOre.SetActive(false);
                currentOre--;
                break;
            case 12:
                platinumOre.SetActive(true);
                obsidianOre.SetActive(false);
                currentOre--;
                break;
            case 13:
                obsidianOre.SetActive(true);
                meteoriteOre.SetActive(false);
                currentOre--;
                break;
            case 14:
                meteoriteOre.SetActive(true);
                mithrilOre.SetActive(false);
                currentOre--;
                break;
            case 15:
                mithrilOre.SetActive(true);
                adamanteusOre.SetActive(false);
                currentOre--;
                break;
            case 16:
                adamanteusOre.SetActive(true);
                quicksilverOre.SetActive(false);
                currentOre--;
                break;
            case 17:
                quicksilverOre.SetActive(true);
                aetherOre.SetActive(false);
                currentOre--;
                break;
            case 18:
                aetherOre.SetActive(true);
                crimsoniteOre.SetActive(false);
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
                aluminiumOre.SetActive(true);
                currentOre++;
                break;
            case 4:
                aluminiumOre.SetActive(false);
                nickelOre.SetActive(true);
                currentOre++;
                break;
            case 5:
                nickelOre.SetActive(false);
                magnesiumOre.SetActive(true);
                currentOre++;
                break;
            case 6:
                magnesiumOre.SetActive(false);
                zincOre.SetActive(true);
                currentOre++;
                break;
            case 7:
                zincOre.SetActive(false);
                leadOre.SetActive(true);
                currentOre++;
                break;
            case 8:
                leadOre.SetActive(false);
                silverOre.SetActive(true);
                currentOre++;
                break;
            case 9:
                silverOre.SetActive(false);
                goldOre.SetActive(true);
                currentOre++;
                break;
            case 10:
                goldOre.SetActive(false);
                platinumOre.SetActive(true);
                currentOre++;
                break;
            case 11:
                platinumOre.SetActive(false);
                obsidianOre.SetActive(true);
                currentOre++;
                break;
            case 12:
                obsidianOre.SetActive(false);
                meteoriteOre.SetActive(true);
                currentOre++;
                break;
            case 13:
                meteoriteOre.SetActive(false);
                mithrilOre.SetActive(true);
                currentOre++;
                break;
            case 14:
                mithrilOre.SetActive(false);
                adamanteusOre.SetActive(true);
                currentOre++;
                break;
            case 15:
                adamanteusOre.SetActive(false);
                quicksilverOre.SetActive(true);
                currentOre++;
                break;
            case 16:
                quicksilverOre.SetActive(false);
                aetherOre.SetActive(true);
                currentOre++;
                break;
            case 17:
                aetherOre.SetActive(false);
                crimsoniteOre.SetActive(true);
                currentOre++;
                break;
            case 18:
                return;
            default:
                return;
        }
    }
}