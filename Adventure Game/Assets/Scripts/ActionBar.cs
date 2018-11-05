using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBar : MonoBehaviour {

    public Image actionBarImage;

    public Sprite actionBarEmpty;

    public string actionBarItem;

    private void Start()
    {
        actionBarImage = GetComponent<Image>();
        actionBarItem = "";
    }

    public void OnClick()
    {
        if (Inventory.inventoryActive)
        {
            actionBarImage.sprite = actionBarEmpty;
            Debug.Log(actionBarItem);
            actionBarItem = "";
        }
        else
        {
            return;
        }
    }
}
