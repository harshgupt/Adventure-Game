using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBrewing : MonoBehaviour {

    public GameObject bladeUI;

    public void Close()
    {
        bladeUI.SetActive(false);
        transform.gameObject.SetActive(false);
    }
}
