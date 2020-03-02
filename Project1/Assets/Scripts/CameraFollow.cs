using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // code from Brackeys tutorial on youtube
    public Transform target;
    public float smoothSpeed = .125f;
    public Vector3 displace;
    public Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
    Vector3 mainPosition = target.position + displace;
    Vector3 smoothPosition = Vector3.SmoothDamp(target.position, mainPosition, ref velocity, smoothSpeed );
    transform.position = smoothPosition;
    }
}
