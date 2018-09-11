﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovementScript : MonoBehaviour {

    float speed = -0.05f;

    private void Update()
    {
        float xPos = Random.Range(0, 3f);
        transform.Translate(speed, 0, 0);
        if(transform.position.x <= xPos)
        {
            speed = 0;
        }
    }
}
