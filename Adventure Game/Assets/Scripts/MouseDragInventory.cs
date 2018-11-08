using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseDragInventory : MonoBehaviour {

    public ActionBar actionBarScript;

    public Transform originalParent;

    public GameObject actionBar;

    public Image slotImage;
    public Image inventoryImage;

    public Vector3 initialPos;

    public int numSlot;

    public string itemName;

    public bool onSlot;

    private void Start()
    {
        originalParent = transform.parent;
        initialPos = transform.position;
        inventoryImage = GetComponent<Image>();
        onSlot = false;
        numSlot = 0;
        itemName = "";
    }

    public void OnMouseDrag()
    {
        string name = transform.gameObject.name;
        char num = name[14];
        switch (num)
        {
            case '1':
                itemName = Inventory.inventorySlotName[0];
                break;
            case '2':
                itemName = Inventory.inventorySlotName[1];
                break;
            case '3':
                itemName = Inventory.inventorySlotName[2];
                break;
            case '4':
                itemName = Inventory.inventorySlotName[3];
                break;
            case '5':
                itemName = Inventory.inventorySlotName[4];
                break;
            case '6':
                itemName = Inventory.inventorySlotName[5];
                break;
            case '7':
                itemName = Inventory.inventorySlotName[6];
                break;
            case '8':
                itemName = Inventory.inventorySlotName[7];
                break;
            default:
                break;
        }
        if (itemName != "")
        {
            transform.parent = actionBar.transform;
            Vector3 objPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            objPos.z = 0;
            transform.position = objPos;
        }
    }

    public void OnMouseUp()
    {
        transform.parent = originalParent;
        transform.SetAsFirstSibling();
        transform.position = initialPos;
        if(onSlot)
        {
            slotImage.sprite = inventoryImage.sprite;
            actionBarScript.actionBarItem = itemName;
        }
        numSlot = 0;
        onSlot = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Action Bar Slot")
        {
            numSlot++;
            onSlot = true;
            slotImage = collision.GetComponent<Image>();
            actionBarScript = collision.GetComponent<ActionBar>();
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Action Bar Slot")
        {
            numSlot--;
            if(numSlot == 0)
            {
                onSlot = false;
            }
        }
    }
}
