using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemMining : MonoBehaviour {

    public const int silverValue = 1;
    public const int goldValue = 2;
    public const int opalValue = 3;
    public const int jadeValue = 4;
    public const int topazValue = 5;
    public const int amethystValue = 6;
    public const int moonstoneValue = 7;
    public const int sunstoneValue = 8;
    public const int rubyValue = 9;
    public const int sapphireValue = 10;
    public const int emeraldValue = 11;
    public const int diamondValue = 12;

    public void SilverMine()
    {
        PlayerData.coins += silverValue;
    }

    public void GoldMine()
    {
        PlayerData.coins += goldValue;
    }

    public void OpalMine()
    {
        PlayerData.coins += opalValue;
    }

    public void JadeMine()
    {
        PlayerData.coins += jadeValue;
    }

    public void TopazMine()
    {
        PlayerData.coins += topazValue;
    }

    public void AmethystMine()
    {
        PlayerData.coins += amethystValue;
    }

    public void MoonstoneMine()
    {
        PlayerData.coins += moonstoneValue;
    }

    public void SunstoneMine()
    {
        PlayerData.coins += sunstoneValue;
    }

    public void RubyMine()
    {
        PlayerData.coins += rubyValue;
    }

    public void SapphireMine()
    {
        PlayerData.coins += sapphireValue;
    }

    public void EmeraldMine()
    {
        PlayerData.coins += emeraldValue;
    }

    public void DiamondMine()
    {
        PlayerData.coins += diamondValue;
    }
}