using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour
{
    private float rotationSpeed = 10.0F;
    private float lerpSpeed = 1.0F;

    private Vector3 theSpeed;
    private Vector3 avgSpeed;
    private bool isDragging = false;
    private Vector3 targetSpeedX;

    void OnMouseDown()
    {
        isDragging = true;
    }

    void Update()
    {
        if(Input.GetMouseButton(0) && isDragging)
        {
            theSpeed = new Vector3(-Input.GetTouch(0).deltaPosition.x / 100.0F, 0, 0.0F);
            avgSpeed = Vector3.Lerp(avgSpeed, theSpeed, Time.deltaTime * 5);
        }
        else
        {
            if(isDragging)
            {
                theSpeed = avgSpeed;
                isDragging = false;
            }
            float i = Time.deltaTime * lerpSpeed;
            theSpeed = Vector3.Lerp(theSpeed, Vector3.zero, i);
        }

        transform.Rotate(transform.up * theSpeed.x * rotationSpeed, Space.World);
    }
}
