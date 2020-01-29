using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{

    public UnityEvent mouseDown;
    public UnityEvent mouseUp;
    public UnityEvent mouseEnter;
    public UnityEvent mouseExit, mouseOver, mouseDrag;
    
    private void OnMouseDown()
    {
        mouseDown.Invoke();
    }
    private void OnMouseUp()
    {
        mouseUp.Invoke();
    }
    private void OnMouseEnter()
    {
        mouseEnter.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOver.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExit.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDrag.Invoke();
    }
}
