using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(Rigidbody))]
public class NewScript : MonoBehaviour
{
/* this is a long comment
 wow
 didn't know I could write a long comment*/

    // code tutorial based off of youtube video from Charger Games
    private Camera myCamera;
    private char character = 'A';
    private Rigidbody thisBody;
    public int myInt = Random.Range(2,14);
    private float myFloat = 2.4f;
    
    void Start()
    {
        
        thisBody = GetComponent<Rigidbody>();
        myCamera = GetComponent<Camera>();
        print(character);
        
        //writes info inside function, instead of writing 5342 lines of code
        TestFunction();
        
        //moves CUBE
        transform.Translate(myFloat,0,0);

        if (myInt < 4)
        {
            print("cool beans, this int is less than 4.");
            print(myInt);
        }
        else if(myInt > 4 && myInt < 13)
        {
            print("int is greater than four but less than 13");
            print(myInt);
        }
        else
        {
            print("Int is too big");
            print(myInt);
        }
    }

    void TestFunction()
    {
        print(myInt);
        print(myFloat);
        print(character);
    }
}
