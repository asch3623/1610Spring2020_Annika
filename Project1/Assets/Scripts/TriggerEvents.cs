using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerStayEvent;
    public UnityEvent triggerExitEvent;
    
    private void OnTriggerEnter(Collider other)
    {
       triggerEnterEvent.Invoke();
       print("cube has touched the sphere");
    }

    private void OnTriggerStay(Collider other)
    {
        print("cube is in position");
    }
    private void OnTriggerExit(Collider other)
    {
        print("you left");
    }
}
