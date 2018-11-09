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

    CircleCollider2D bladeCollider;

    public Image inventoryImage;
    public Image progressBar;

    public Text inventoryAmount;

    public float timer;

    public int currentSpell = 0;
    public static int numNodes = 4;
    public static int nodesDone = 0;

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
        }
        timer += Time.deltaTime;
        if(timer >= 1f)
        {
            timer = 0;
            progressBar.fillAmount -= 0.01f;
        }
        if (progressBar.fillAmount < 0)
        {
            progressBar.fillAmount = 0;
        }
        if (progressBar.fillAmount >= 1)
        {
            ResetAll();
            CloseSpellbook();
            pData.magicSpells[currentSpell].amount++;
        }
        if (!bladeLineScript.GetComponent<CircleCollider2D>().isActiveAndEnabled)
        {
            progressBar.fillAmount = 0;
            for (int i = 0; i < initialNodes.Length; i++)
            {
                initialNodes[i].SetActive(true);
            }
            for (int i = 0; i < midNodes.Length; i++)
            {
                midNodes[i].SetActive(false);
            }
            nodesDone = 0;
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
        numNodes = 4;
        nodesDone = 0;
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
        numNodes = 4;
    }

    public void WaterSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        waterNodes.SetActive(true);
        numNodes = 7;
    }

    public void FireSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        fireNodes.SetActive(true);
        numNodes = 7;
    }

    public void WindSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        windNodes.SetActive(true);
        numNodes = 8;
    }

    public void IceSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        iceNodes.SetActive(true);
        numNodes = 7;
    }

    public void EarthSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        earthNodes.SetActive(true);
        numNodes = 6;
    }

    public void SummoningSpellCreation()
    {
        ResetAll();
        bladeLine.SetActive(true);
        spellbookUI.SetActive(true);
        summoningNodes.SetActive(true);
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
