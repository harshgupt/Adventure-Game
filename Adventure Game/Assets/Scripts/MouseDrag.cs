using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    public static bool condition = false;
    public static bool holding = false;

    public void OnMouseDrag()
    {
        if (condition)
        {
            holding = true;
            Vector3 objPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            objPos.z = 0;
            transform.position = objPos;
        }
    }
}
