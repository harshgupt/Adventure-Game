using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionBrewing : MonoBehaviour {

    public Camera cam;

    public Blade bladeUIScript;

    public GameObject bladeUI;

    public Image progressBar;

    public Vector2 startPosition;
    public Vector2 currentPosition;
    public Vector2 prevPosition;
    public Vector2 circleCenter = new Vector2(0, 0);
    public Vector2 touchPosition;

    private const float circleRadius = 3f;
    public float angle;

    public int maxNumTurns = 10;

    public bool isDrawing = false;
    public bool movedOut = false;

    private void Update()
    {
#if !UNITY_EDITOR
        Touch touch = Input.touches[0];
        if(touch.phase == TouchPhase.Began)
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(touch.position)) <= circleRadius)
            {
                touchPosition = cam.ScreenToWorldPoint(touch.position);
                StartDrawing();
            }
        }
        if(touch.phase == TouchPhase.Ended)
        {
            StopDrawing();
        }
        if(touch.phase == TouchPhase.Moved)
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(touch.position)) <= circleRadius && movedOut)
            {
                movedOut = false;
                touchPosition = cam.ScreenToWorldPoint(touch.position);
                StartDrawing();
            }
        }
#else
        if (Input.GetMouseButtonDown(0))
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(Input.mousePosition)) <= circleRadius)
            {
                touchPosition = cam.ScreenToWorldPoint(Input.mousePosition);
                StartDrawing();
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopDrawing();
        }
#endif
        if (isDrawing)
        {
#if !UNITY_EDITOR
            touchPosition = cam.ScreenToWorldPoint(touch.position);
#else
            touchPosition = cam.ScreenToWorldPoint(Input.mousePosition);
#endif
            if (Vector2.Distance(circleCenter, touchPosition) <= circleRadius)
            {
                Vector2 v1 = prevPosition - circleCenter;
                currentPosition = touchPosition;
                Vector2 v2 = currentPosition - circleCenter;
                Vector2 v3 = startPosition - circleCenter;
                angle += Vector2.SignedAngle(v2, v1);
                //num is number of clockwise circles
                int num = (int)angle / 360;
                Debug.Log(num);
                progressBar.fillAmount = (float)num / maxNumTurns;
                prevPosition = currentPosition;
            }
            else
            {
                movedOut = true;
                StopDrawing();
            }
        }
    }

    public void StartDrawing()
    {
        startPosition = touchPosition;
        currentPosition = touchPosition;
        prevPosition = touchPosition;
        isDrawing = true;
    }

    public void StopDrawing()
    {
        isDrawing = false;
    }

    public void Close()
    {
        if (bladeUI.activeSelf)
        {
            bladeUIScript.StopCuttingForUI();
            bladeUI.SetActive(false);
        }
        transform.gameObject.SetActive(false);
    }
}
