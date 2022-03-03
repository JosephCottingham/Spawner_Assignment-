using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = .15f;
    public Vector3 offset = new Vector3(-6, -2, 0);

    void FixedUpdate()
    {
        Vector3 desiredPos = target.position - offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;
        //transform.LookAt(target);
    }
}
