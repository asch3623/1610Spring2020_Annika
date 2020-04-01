using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using DataTypes;

public class Coroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public string message = "GO";
    public IntData numberData;

    public UnityEvent repeatEvent, startEvent, endEvent, postEndEvent;

    private WaitForSeconds waitObj;
   private IEnumerator Start()
    {
        waitObj = new WaitForSeconds(seconds);
        startEvent.Invoke();
        
        while (counter > 0)
        {
            numberData.value = counter;
            yield return new WaitForSeconds(seconds);
            repeatEvent.Invoke();
            counter--;
        }
        yield return waitObj;
        endEvent.Invoke();
        yield return waitObj;
        postEndEvent.Invoke();
    }

    
}
