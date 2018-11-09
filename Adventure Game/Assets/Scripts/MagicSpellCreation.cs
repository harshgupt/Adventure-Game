using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSpellCreation : MonoBehaviour {

    public Blade bladeLineScript;

    public PlayerData pData;

    public GameObject bladeLine;
    public GameObject spellbookUI;
    public GameObject lightningSpell;
    public GameObject waterSpell;
    public GameObject fireSpell;
    public GameObject windSpell;
    public GameObject iceSpell;
    public GameObject earthSpell;
    public GameObject summoningSpell;
    public GameObject lightningNodes;
    public GameObject waterNodes;
    public GameObject fireNodes;
    public GameObject windNodes;
    public GameObject iceNodes;
    public GameObject earthNodes;
    public GameObject summoningNodes;

    public GameObject[] initialNodes = new GameObject[7];
    public GameObject[] midNodes = new GameObject[38];

    public Image inventoryImage;
    public Image progressBar;

    public Text inventoryAmount;

    public int currentSpell = 0;
    public int numIterations = 10;
    public static int numNodes = 4;
    public static int nodesDone = 0;
    public static int iterationsDone = 0;

    private void Start()
    {
        ResetAll();
    }

    private void Update()
    {
        DisplayInventoryAmount();
        if(nodesDone >= numNodes)
        {
            nodesDone = 0;
            iterationsDone++;
        }
        progressBar.fillAmount = (float)iterationsDone / numIterations;
        if(iterationsDone >= numIterations)
        {
            iterationsDone = 0;
            ResetAll();
            CloseSpellbook();
            pData.magicSpells[currentSpell].amount++;
        }
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.magicSpells[currentSpell].sprite;
        inventoryAmount.text = pData.magicSpells[currentSpell].amount.ToString();
    }

    public void ResetAll()
    {
        for(int i = 0; i < initialNodes.Length; i++)
        {
            initialNodes[i].SetActive(true);
        }
        for(int i = 0; i < midNodes.Length; i++)
        {
            midNodes[i].SetActive(false);
        }
        progressBar.fillAmount = 0;
        numIterations = 10;
        numNodes = 4;
        nodesDone = 0;
        iterationsDone = 0;
        lightningNodes.SetActive(false);
        waterNodes.SetActive(false);
        fireNodes.SetActive(false);
        windNodes.SetActive(false);
        iceNodes.SetActive(false);
        earthNodes.SetActive(false);
        summoningNodes.SetActive(false);
    }

    public void LightningSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        lightningNodes.SetActive(true);
        numIterations = 2;
        numNodes = 4;
    }

    public void WaterSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        waterNodes.SetActive(true);
        numIterations = 2;
        numNodes = 7;
    }

    public void FireSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        fireNodes.SetActive(true);
        numIterations = 2;
        numNodes = 7;
    }

    public void WindSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        windNodes.SetActive(true);
        numIterations = 2;
        numNodes = 8;
    }

    public void IceSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        iceNodes.SetActive(true);
        numIterations = 2;
        numNodes = 7;
    }

    public void EarthSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        earthNodes.SetActive(true);
        numIterations = 2;
        numNodes = 6;
    }

    public void SummoningSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        summoningNodes.SetActive(true);
        numIterations = 2;
        numNodes = 6;
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
        transform.gameObject.SetActive(false);
    }

    public void CloseSpellbook()
    {
        if (bladeLine.activeSelf)
        {
            bladeLineScript.StopCuttingForUI();
            bladeLine.SetActive(false);
        }
        ResetAll();
        spellbookUI.SetActive(false);
    }
}
