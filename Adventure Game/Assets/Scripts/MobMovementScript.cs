using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovementScript : MonoBehaviour {

    float speed = -0.01f;

    private void Update()
    {
        transform.Translate(speed, 0, 0);
        if(transform.position.x <= 0)
        {
            speed = 0;
        }
    }
}
