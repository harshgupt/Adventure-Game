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
        //transform.localScale = transform.localScale * (ratio) / 2;
        Camera.main.orthographicSize = 7.64f / (ratio * 1.5f);
        Debug.Log(height + " " + width + " " + ratio);
    }
}
