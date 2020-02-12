using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{

    private Camera myCamera;

    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
        myCamera.depth = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
