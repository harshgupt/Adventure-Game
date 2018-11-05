using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseDragInventory : MonoBehaviour {

    public GameObject actionBar;
    public GameObject inventoryList;

    public Image slotImage;
    public Image inventoryImage;

    public Vector3 initialPos;

    public int numSlot;

    public bool onSlot;

    private void Start()
    {
        initialPos = transform.position;
        inventoryImage = GetComponent<Image>();
        onSlot = false;
        numSlot = 0;
    }

    public void OnMouseDrag()
    {
        transform.parent = actionBar.transform;
        Vector3 objPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objPos.z = 0;
        transform.position = objPos;
    }

    public void OnMouseUp()
    {
        transform.parent = inventoryList.transform;
        transform.position = initialPos;
        if(onSlot)
        {
            slotImage.sprite = inventoryImage.sprite;
        }
        numSlot = 0;
        onSlot = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ActionBarSlot")
        {
            numSlot++;
            onSlot = true;
            slotImage = collision.GetComponent<Image>();
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ActionBarSlot")
        {
            numSlot--;
            if(numSlot == 0)
            {
                onSlot = false;
            }
        }
    }
}
