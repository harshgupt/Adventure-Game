using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovementScript : MonoBehaviour {

    public GameObject canvasHP;

    public Collider2D ownCollider;

    float yPos;
    float xPos;
    float speed = -0.5f;

    private void Start()
    {
        yPos = transform.position.y;
        if(yPos == 2f || yPos == -1f)
        {
            xPos = 0;
        }
        else if(yPos == 3.5f || yPos == 0.5 || yPos == -2.5f)
        {
            xPos = 2f;
        }
    }

    void Update()
    {
        if (transform.position.x <= xPos)
        {
            speed = 0;
            canvasHP.SetActive(true);
            ownCollider.enabled = true;
        }
        transform.Translate(speed, 0, 0);
    }
}
