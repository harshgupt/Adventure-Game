using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoins : MonoBehaviour {

    public Text coinText;

    public float shortenedValue;

    public int decimalThreeValue;

    private void Update()
    {
        //double temp2 = 1000000000000000000;
        //Debug.Log(temp2);
        if(PlayerData.coins < 1000)
        {
            coinText.text = PlayerData.coins.ToString();
        }
        else if(PlayerData.coins < 1000000)
        {
            decimalThreeValue = (int)PlayerData.coins / 10;
            shortenedValue = decimalThreeValue / 100;
            coinText.text = shortenedValue.ToString() + "K";
        }
        else if(PlayerData.coins < 1000000000)
        {
            double temp = PlayerData.coins / 1000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            coinText.text = shortenedValue.ToString() + "M";
        }
        else if (PlayerData.coins < 1000000000000)
        {
            double temp = PlayerData.coins / 1000000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            coinText.text = shortenedValue.ToString() + "B";
        }
        else if (PlayerData.coins < 1000000000000000)
        {
            double temp = PlayerData.coins / 1000000000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            coinText.text = shortenedValue.ToString() + "T";
        }
        else if (PlayerData.coins < 1000000000000000000)
        {
            double temp = PlayerData.coins / 1000000000000;
            decimalThreeValue = (int)temp / 10;
            shortenedValue = decimalThreeValue / 100;
            coinText.text = shortenedValue.ToString() + "Q";
        }
    }
}
