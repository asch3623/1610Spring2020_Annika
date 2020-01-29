using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int myInt;
    public string myString;
    public float myFloat;
    public UnityEvent enterEvent;
    public UnityEvent stayEvent;
    public UnityEvent exitEvent;

    public void OnTriggerEnter(Collider other)
    {
        myInt = 7;
        print(myInt);
        enterEvent.Invoke();
    }
    public void OnTriggerStay(Collider other)
    {
        myFloat = 5;
        print(myFloat);
        stayEvent.Invoke();
    }
    public void OnTriggerExit(Collider other)
    {
        print(myString);
        exitEvent.Invoke();
    }
}
