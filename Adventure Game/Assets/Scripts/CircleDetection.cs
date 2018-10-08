using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDetection : MonoBehaviour {
    public Camera cam;

    public Vector2 startPosition;
    public Vector2 currentPosition;
    public Vector2 prevPosition;
    public Vector2 circleCenter = new Vector2(0,0);

    private const float circleRadius = 3f;
    public float angle;

    public bool isDrawing = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(Input.mousePosition)) <= circleRadius)
            {
                StartDrawing();
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopDrawing();
        }
        if (isDrawing)
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(Input.mousePosition)) <= circleRadius)
            {
                Vector2 v1 = prevPosition - circleCenter;
                currentPosition = cam.ScreenToWorldPoint(Input.mousePosition);
                Vector2 v2 = currentPosition - circleCenter;
                Vector2 v3 = startPosition - circleCenter;
                angle += Vector2.SignedAngle(v2, v1);
                //num is number of clockwise circles
                int num = (int)angle / 360;
                Debug.Log(num);
                prevPosition = currentPosition;
            }
            else
            {
                StopDrawing();
            }
        }
    }

    public void StartDrawing()
    {
        startPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        currentPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        prevPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        isDrawing = true;
    }

    public void StopDrawing()
    {
        isDrawing = false;
    }
}
