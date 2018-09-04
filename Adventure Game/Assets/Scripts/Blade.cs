using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    public GameObject prefabBladeTrail;

    Camera cam;
    GameObject currentBladeTrail;
    Rigidbody2D rb;
    CircleCollider2D circleCollider;
    Vector2 previousPosition;
    Vector2 touchPosition;
    bool isCutting = false;

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    void Update ()
    {
#if !UNITY_EDITOR
        Touch touch = Input.touches[0];
        if(touch.phase == TouchPhase.Began)
        {
            touchPosition = touch.position;
            StartCutting();
        }
        else if(touch.phase == TouchPhase.Moved)
        {
            touchPosition = touch.position;
        }
        else if(touch.phase == TouchPhase.Ended)
        {
            StopCutting();
        }
#else
        if (Input.GetMouseButtonDown(0))
        {
            touchPosition = Input.mousePosition;
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }
#endif
        if (isCutting)
        {
            UpdateBlade();
        }
	}

    public void UpdateBlade()
    {
#if !UNITY_EDITOR
        Vector2 newPosition = cam.ScreenToWorldPoint(touchPosition);
#else
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
#endif
        rb.position = newPosition;
        previousPosition = newPosition;
    }

    public void StartCutting()
    {
        isCutting = true;
        rb.position = cam.ScreenToWorldPoint(touchPosition);
        transform.position = rb.position;
        currentBladeTrail = Instantiate(prefabBladeTrail, transform);
        previousPosition = cam.ScreenToWorldPoint(touchPosition);
        circleCollider.enabled = true;
    }

    public void StopCutting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 0.5f);
        circleCollider.enabled = false;
    }
}
