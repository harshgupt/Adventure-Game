using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitOrchard : MonoBehaviour {

    public PlayerData pData;

    public GameObject rubyApple;
    public GameObject bloodOrange;
    public GameObject cinderBanana;
    public GameObject dewLemon;
    public GameObject goldenMango;
    public GameObject wildNectarine;

    public Image inventoryImage;

    public Text inventoryAmount;

    public int currentFruit = 0;

    private void Update()
    {
        DisplayInventoryAmount();
    }

    public void RubyAppleCollect()
    {
        pData.fruits[0].amount++;
    }

    public void BloodOrangeCollect()
    {
        pData.fruits[1].amount++;
    }

    public void CinderBananaCollect()
    {
        pData.fruits[2].amount++;
    }

    public void DewLemonCollect()
    {
        pData.fruits[3].amount++;
    }

    public void GoldenMangoCollect()
    {
        pData.fruits[4].amount++;
    }

    public void WildNectarineCollect()
    {
        pData.fruits[5].amount++;
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.fruits[currentFruit].sprite;
        inventoryAmount.text = pData.fruits[currentFruit].amount.ToString();
    }

    public void LeftButton()
    {
        switch (currentFruit)
        {
            case 0:
                return;
            case 1:
                rubyApple.SetActive(true);
                bloodOrange.SetActive(false);
                currentFruit--;
                break;
            case 2:
                bloodOrange.SetActive(true);
                cinderBanana.SetActive(false);
                currentFruit--;
                break;
            case 3:
                cinderBanana.SetActive(true);
                dewLemon.SetActive(false);
                currentFruit--;
                break;
            case 4:
                dewLemon.SetActive(true);
                goldenMango.SetActive(false);
                currentFruit--;
                break;
            case 5:
                goldenMango.SetActive(true);
                wildNectarine.SetActive(false);
                currentFruit--;
                break;
        }
    }

    public void RightButton()
    {
        switch (currentFruit)
        {
            case 0:
                rubyApple.SetActive(false);
                bloodOrange.SetActive(true);
                currentFruit++;
                break;
            case 1:
                bloodOrange.SetActive(false);
                cinderBanana.SetActive(true);
                currentFruit++;
                break;
            case 2:
                cinderBanana.SetActive(false);
                dewLemon.SetActive(true);
                currentFruit++;
                break;
            case 3:
                dewLemon.SetActive(false);
                goldenMango.SetActive(true);
                currentFruit++;
                break;
            case 4:
                goldenMango.SetActive(false);
                wildNectarine.SetActive(true);
                currentFruit++;
                break;
            case 5:
                return;
        }
    }
}
