using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovementScript : MonoBehaviour {

    float speed = -0.1f;
    int xPos;

    private void Start()
    {
        xPos = Random.Range(0, 4);
    }

    void Update()
    {
        if (transform.position.x <= xPos)
        {
            speed = 0;
        }
        transform.Translate(speed, 0, 0);
    }
}
