using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoins : MonoBehaviour {

    public Text coinText;

    private void Update()
    {
        coinText.text = PlayerData.coins.ToString();
    }
}
