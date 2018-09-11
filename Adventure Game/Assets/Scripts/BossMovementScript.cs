using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovementScript : MonoBehaviour {

    float speed = -0.02f;

    private void Update()
    {
        if (transform.position.x <= 6.5f)
        {
            speed = 0;
        }
        transform.Translate(speed, 0, 0);
    }
}
