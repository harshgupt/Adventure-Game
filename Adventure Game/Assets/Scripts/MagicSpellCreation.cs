using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSpellCreation : MonoBehaviour {

    public Blade bladeUIScript;

    public GameObject bladeUI;
    public GameObject lightningSpell;
    public GameObject waterSpell;
    public GameObject fireSpell;
    public GameObject windSpell;
    public GameObject iceSpell;
    public GameObject earthSpell;
    public GameObject summoningSpell;

    public PlayerData pData;

    public Image inventoryImage;

    public Text inventoryAmount;

    public int currentSpell = 0;

    private void Update()
    {
        DisplayInventoryAmount();
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.magicSpells[currentSpell].sprite;
        inventoryAmount.text = pData.magicSpells[currentSpell].amount.ToString();
    }

    public void LeftButton()
    {
        switch (currentSpell)
        {
            case 0:
                return;
            case 1:
                lightningSpell.SetActive(true);
                waterSpell.SetActive(false);
                currentSpell--;
                break;
            case 2:
                waterSpell.SetActive(true);
                fireSpell.SetActive(false);
                currentSpell--;
                break;
            case 3:
                fireSpell.SetActive(true);
                windSpell.SetActive(false);
                currentSpell--;
                break;
            case 4:
                windSpell.SetActive(true);
                iceSpell.SetActive(false);
                currentSpell--;
                break;
            case 5:
                iceSpell.SetActive(true);
                earthSpell.SetActive(false);
                currentSpell--;
                break;
            case 6:
                earthSpell.SetActive(true);
                summoningSpell.SetActive(false);
                currentSpell--;
                break;
            default:
                return;
        }
    }

    public void RightButton()
    {
        switch (currentSpell)
        {
            case 0:
                lightningSpell.SetActive(false);
                waterSpell.SetActive(true);
                currentSpell++;
                break;
            case 1:
                waterSpell.SetActive(false);
                fireSpell.SetActive(true);
                currentSpell++;
                break;
            case 2:
                fireSpell.SetActive(false);
                windSpell.SetActive(true);
                currentSpell++;
                break;
            case 3:
                windSpell.SetActive(false);
                iceSpell.SetActive(true);
                currentSpell++;
                break;
            case 4:
                iceSpell.SetActive(false);
                earthSpell.SetActive(true);
                currentSpell++;
                break;
            case 5:
                earthSpell.SetActive(false);
                summoningSpell.SetActive(true);
                currentSpell++;
                break;
            case 6:
                return;
            default:
                return;
        }
    }

    public void Close()
    {
        if (bladeUI.activeSelf)
        {
            bladeUIScript.StopCuttingForUI();
            bladeUI.SetActive(false);
        }
        transform.gameObject.SetActive(false);
    }
}
