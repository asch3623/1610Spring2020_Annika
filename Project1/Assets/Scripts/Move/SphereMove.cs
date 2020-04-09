using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SphereMove : MonoBehaviour
{
   // code from https://www.raywenderlich.com/980-introduction-to-unity-scripting
   public float acceleration;
   public float maxSpeed;

   private Rigidbody rigidBody;
   private KeyCode[] inputKeys;
   private Vector3[] directionsForKeys;

   void Start()
   {
       inputKeys = new KeyCode[] {KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D};
       directionsForKeys = new Vector3[] {Vector3.forward, Vector3.left, Vector3.back, Vector3.right};
       rigidBody = GetComponent<Rigidbody>();
   }

    // use fixedupdate with rigidbodies
    void FixedUpdate()
    {
        for (int i = 0; i < inputKeys.Length; i++)
        {
            var key = inputKeys[i];
            // checks for input keys
            if (Input.GetKey(key))
            {
                //moves player in direction of input key
                Vector3 movement = directionsForKeys[i] * acceleration * Time.deltaTime;
                movePlayer(movement);
            }
        }
    }
//limits max speed
    void movePlayer(Vector3 movement)
    {
        if (rigidBody.velocity.magnitude * acceleration > maxSpeed)
        {
            rigidBody.AddForce(movement * -1);
        }
        else
        {
            rigidBody.AddForce(movement);
        }
    }
}
