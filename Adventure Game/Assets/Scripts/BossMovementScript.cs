using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovementScript : MonoBehaviour {

    public GameObject canvasHP;

    public Collider2D ownCollider;

    float speed = -0.25f;

    public bool reachedEnd = false;

    private void Update()
    {
        if (transform.position.x <= 1f)
        {
            speed = 0;
            canvasHP.SetActive(true);
            ownCollider.enabled = true;
            reachedEnd = true;
        }
        transform.Translate(speed, 0, 0);
    }
}
