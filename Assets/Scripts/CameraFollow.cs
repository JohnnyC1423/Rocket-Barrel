﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.0125f;
    public float resetSpeed = 2f;
    public Vector3 offset;
    public Vector3 startPos;
    Vector3 desiredPosition;

    private void FixedUpdate()
    {

        if (GameObject.FindWithTag("Player") != null)
        {
            desiredPosition = target.position + offset;
        }
        else
        {
            desiredPosition = startPos;
        }
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(transform.position.x, smoothedPosition.y, smoothedPosition.z);

    }

}
