using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // code from Brackeys tutorial on youtube
    public Transform player;
    public Vector3 displace;

    void start()
    {
        displace = transform.position - player.position;
    }
    void Update()
    {
        transform.position = player.position + displace;
    }
}
