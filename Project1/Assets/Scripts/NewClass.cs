using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewClass : MonoBehaviour
{

    public UnityEvent uEvent;
    public int scoreValue;
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    
    // Start is called before the first frame update
    private void Start()
    {
        uEvent.Invoke();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
