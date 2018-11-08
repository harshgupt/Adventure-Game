using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public PlayerData pData;

    public const int maxWeapon = 220;
    public const int maxArmour = 220;

    private void Start()
    {
        //Debug.Log(Mathf.Ceil(475f * Mathf.Pow(1.15f, 219)));
        //Debug.Log(Mathf.Ceil(400f * Mathf.Pow(1.15f, 219)));
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
    }

    public void UpgradeChestplate()
    {
        int tier = PlayerData.armourTier[1];
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(75f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(2 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier[1]++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier[1]);
        }
    }

    public void UpgradeLeggings()
    {
        int tier = PlayerData.armourTier[3];
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(75f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(2 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier[3]++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier[3]);
        }
    }

    public void UpgradeShield()
    {
        int tier = PlayerData.armourTier[5];
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(75f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(2 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier[5]++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier[5]);
        }
    }

    public void UpgradeHelm()
    {
        int tier = PlayerData.armourTier[0];
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(50f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier[0]++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier[0]);
        }
    }

    public void UpgradeGauntlets()
    {
        int tier = PlayerData.armourTier[2];
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(50f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier[2]++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier[2]);
        }
    }

    public void UpgradeBoots()
    {
        int tier = PlayerData.armourTier[4];
        if (tier > maxArmour)
        {
            Debug.Log("Max level achieved");
            return;
        }
        float numCoins = Mathf.Ceil(50f * Mathf.Pow(1.15f, tier));
        float numMetals = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        float numGems = Mathf.Ceil(1 * Mathf.Pow(1.15f, tier));
        int metalIndex = tier / 5;
        int gemIndex = tier * 2 / 15;
        if (PlayerData.coins < numCoins /*|| pData.metals[metalIndex].amount < numMetals || pData.gems[gemIndex].amount < numGems*/)
        {
            Debug.Log("Need: " + numCoins + " coins, " + numMetals + " metal, and " + numGems + " gems");
            return;
        }
        else
        {
            PlayerData.armourTier[4]++;
            PlayerData.coins -= numCoins;
            //pData.metals[metalIndex].amount -= numMetals;
            //pData.gems[gemIndex].amount -= numGems;
            Debug.Log("Tier: " + PlayerData.armourTier[4]);
        }
    }
}
