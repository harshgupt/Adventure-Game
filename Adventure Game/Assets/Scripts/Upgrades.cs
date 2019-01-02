using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public PlayerData pData;

    public Text[] upgradeText = new Text[7];

    public const int maxWeapon = 220;
    public const int maxArmour = 220;

    private void Start()
    {
        //Debug.Log(Mathf.Ceil(475f * Mathf.Pow(1.15f, 219)));
        //Debug.Log(Mathf.Ceil(400f * Mathf.Pow(1.15f, 219)));
        DisplayValues();
    }

    public void UpgradeWeapon()
    {
        int tier = PlayerData.weaponTier;
        if(tier > maxWeapon)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(100f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(2 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(2 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if(PlayerData.coins < numCoins/* || pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.weaponTier++;
            PlayerData.playerDamage = Mathf.Ceil(1 * Mathf.Pow(1.14f, PlayerData.weaponTier));
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.weaponTier);
        }
        DisplayValues();
    }

    public void UpgradeArmour()
    {
        int tier = PlayerData.armourTier;
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(150f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(5 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(3 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier);
        }
        DisplayValues();
    }

    public void DisplayValues()
    {
        float shortenedValue;
        int decimalThreeValue;
        int tier = PlayerData.weaponTier;
        float numCoins = Mathf.Ceil(100f * Mathf.Pow(1.15f, tier));
        if (numCoins < 1000)
        {
            upgradeText[0].text = numCoins.ToString();
        }
        else if (numCoins < 1000000)
        {
            decimalThreeValue = (int)numCoins / 10;
            shortenedValue = decimalThreeValue / 100;
            upgradeText[0].text = shortenedValue.ToString() + "K";
        }
        else if (numCoins < 1000000000)
        {
            double temp = numCoins / 1000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            upgradeText[0].text = shortenedValue.ToString() + "M";
        }
        else if (numCoins < 1000000000000)
        {
            double temp = numCoins / 1000000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            upgradeText[0].text = shortenedValue.ToString() + "B";
        }
        else if (numCoins < 1000000000000000)
        {
            double temp = numCoins / 1000000000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            upgradeText[0].text = shortenedValue.ToString() + "T";
        }
        else if (numCoins < 1000000000000000000)
        {
            double temp = numCoins / 1000000000000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            upgradeText[0].text = shortenedValue.ToString() + "Q";
        }
        for (int i = 0; i <= 5; i++)
        {
            tier = PlayerData.armourTier;
            numCoins = Mathf.Ceil(150f * Mathf.Pow(1.15f, tier));
            if (numCoins < 1000)
            {
                upgradeText[i + 1].text = numCoins.ToString();
            }
            else if (numCoins < 1000000)
            {
                decimalThreeValue = (int)numCoins / 10;
                shortenedValue = decimalThreeValue / 100;
                upgradeText[i + 1].text = shortenedValue.ToString() + "K";
            }
            else if (numCoins < 1000000000)
            {
                double temp = numCoins / 1000;
                decimalThreeValue = (int)temp / 10;
                shortenedValue = decimalThreeValue / 100;
                upgradeText[i + 1].text = shortenedValue.ToString() + "M";
            }
            else if (numCoins < 1000000000000)
            {
                double temp = numCoins / 1000000;
                decimalThreeValue = (int)temp / 10;
                shortenedValue = decimalThreeValue / 100;
                upgradeText[i + 1].text = shortenedValue.ToString() + "B";
            }
            else if (numCoins < 1000000000000000)
            {
                double temp = numCoins / 1000000000;
                decimalThreeValue = (int)temp / 10;
                shortenedValue = decimalThreeValue / 100;
                upgradeText[i + 1].text = shortenedValue.ToString() + "T";
            }
            else if (numCoins < 1000000000000000000)
            {
                double temp = numCoins / 1000000000000;
                decimalThreeValue = (int)temp / 10;
                shortenedValue = decimalThreeValue / 100;
                upgradeText[i + 1].text = shortenedValue.ToString() + "Q";
            }
        }
    }
}
