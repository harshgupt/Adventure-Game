using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour {

    public float height;
    public float width;
    public float ratio;

    void Start()
    {
        height = Screen.height;
        width = Screen.width;
        ratio = height / width;
        //transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * ratio / 2, transform.localScale.z);
        transform.localScale = transform.localScale * ratio / 2;
        //transform.localPosition = transform.localPosition * ratio / 2;
    }
}
