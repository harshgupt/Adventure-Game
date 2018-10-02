using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovementScript : MonoBehaviour {

    float speed = -0.25f;

    private void Update()
    {
        if (transform.position.x <= 1f)
        {
            speed = 0;
        }
        transform.Translate(speed, 0, 0);
    }
}
