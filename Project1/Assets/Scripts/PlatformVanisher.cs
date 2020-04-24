using System.Collections;
using DataTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.VFX;

public class PlatformVanisher : MonoBehaviour
{
    public BoolData isEnabled;
    private BoxCollider2D col;
    public UnityEvent fadeOut;


    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
         if (other.gameObject.tag == "Player")
         {
                    print("istouching");
                    fadeOut.Invoke();
                    StartCoroutine(TimeToWait());

         }
    }

    IEnumerator TimeToWait()
    {
        yield return new WaitForSeconds(0.5f);
        isEnabled.value = false;
        col.enabled = false;
        Destroy(this.gameObject);

    }
   
}
