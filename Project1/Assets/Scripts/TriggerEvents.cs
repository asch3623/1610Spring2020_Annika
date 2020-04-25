using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
       triggerEnterEvent.Invoke();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        triggerExitEvent.Invoke();
    }
}
