using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbGarden : MonoBehaviour {
    
    public GameObject bladeUI;

    public void UpButton()
    {

    }

    public void DownButton()
    {

    }

    public void Close()
    {
        bladeUI.SetActive(false);
        transform.gameObject.SetActive(false);
    }
}
