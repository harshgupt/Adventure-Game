using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiningScript : MonoBehaviour {

    public Text amountText;
    public static int amount = 0;

    public void OnMouseDown()
    {
        if(gameObject.tag == "Ore")
        {
            amount++;
            amountText.text = amount.ToString();
        }
    }
}
