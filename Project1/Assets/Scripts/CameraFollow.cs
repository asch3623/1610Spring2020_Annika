using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // code from Brackeys tutorial on youtube
    public Transform target;
    public float smoothSpeed = .125f;
    public Vector3 displace;


    void LateUpdate()
    {
   transform.position = target.position + displace * Time.deltaTime;
    }
}
