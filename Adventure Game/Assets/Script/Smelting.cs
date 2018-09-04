using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelting : MonoBehaviour {

    public Text copperOreAmount;
    public Text tinOreAmount;
    public Text ironOreAmount;
    public Text coalOreAmount;
    public Text leadOreAmount;

    private void Start()
    {
        copperOreAmount.text = Inventory.copperOre.ToString();
        tinOreAmount.text = Inventory.tinOre.ToString();
        ironOreAmount.text = Inventory.ironOre.ToString();
        coalOreAmount.text = Inventory.coalOre.ToString();
        leadOreAmount.text = Inventory.leadOre.ToString();
    }
}
