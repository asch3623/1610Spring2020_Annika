using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [RequireComponent(typeof(TrailRenderer))]
public class FollowCursor : MonoBehaviour
{
   
    // tutorial from https://www.youtube.com/watch?v=_TcEfIXpmRI
    private TrailRenderer trail;
    
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            trail.startColor = Color.green;
        }
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
}
