using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smelting : MonoBehaviour {

    public InventoryOreMetal inventoryScript;

    private void Start()
    {
        inventoryScript.RemoveItem("Copper Ore", 0);
        PlayerData.ores[0] = 0;
    }

}
