using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitOrchard : MonoBehaviour {

    public GameObject rubyApple;
    public GameObject bloodOrange;
    public GameObject cinderBanana;
    public GameObject dewLemon;
    public GameObject goldenMango;
    public GameObject wildNectarine;

    public int currentFruit = 0;

    public void RubyAppleCollect()
    {
        PlayerData.fruits[0]++;
    }

    public void BloodOrangeCollect()
    {
        PlayerData.fruits[1]++;
    }

    public void CinderBananaCollect()
    {
        PlayerData.fruits[2]++;
    }

    public void DewLemonCollect()
    {
        PlayerData.fruits[3]++;
    }

    public void GoldenMangoCollect()
    {
        PlayerData.fruits[4]++;
    }

    public void WildNectarineCollect()
    {
        PlayerData.fruits[5]++;
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
