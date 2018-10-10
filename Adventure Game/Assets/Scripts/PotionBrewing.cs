using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBrewing : MonoBehaviour {

    public Blade bladeUIScript;

    public GameObject bladeUI;

    public void Close()
    {
        if (bladeUI.activeSelf)
        {
            bladeUIScript.StopCuttingForUI();
            bladeUI.SetActive(false);
        }
        transform.gameObject.SetActive(false);
    }
}
