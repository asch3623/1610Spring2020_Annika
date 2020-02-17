using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(GameObject))]
[RequireComponent(typeof(PrimitiveType))]

public class NewClass : MonoBehaviour
{
    Camera newCamera;
    public UnityEvent uEvent;
    public int scoreValue;
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    public bool destroyCheck;
    public Transform objPos;

    public PrimitiveType Sphere;

    // Start is called before the first frame update
    private void Start()
    {
        uEvent.Invoke();
        newCamera = GetComponent<Camera>();
        Sphere = GetComponent<PrimitiveType>();

        //code from Charger Games tutorial, destroys after 4 seconds
        //Destroy(gameObject, 4f);
    }

    void DestroyObject()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
    }


    private void Update()
    {
        //code from Charger Games Unity youtube video
        if (Input.GetKeyDown(KeyCode.Space) && destroyCheck)
        {
            print("object is gone!");
            DestroyObject();
            destroyCheck = false;
        }
        // my own adapated version
        if (Input.GetKeyDown(KeyCode.R) && !destroyCheck)
        {
            print("R is pressed");
            Instantiate(gameObj, objPos.position, objPos.rotation);
            destroyCheck = true;
            gameObj.tag = "Player";
        }
    }
}
