using UnityEngine;
using UnityEngine.Events;

public class AnotherScript : MonoBehaviour {

public string thisString;
public UnityEvent uEvent;
public int thisNum;
public string stringNum;
public GameObject thisCube;
public int scoreValue;

// Use this for initialization
	void Start () {
	uEvent.Invoke();
	print(thisNum);
	print("hello friends");
	print("this is working?");
	print("hello world");
	print("do you hear me?");
	print("I am your computer. I have become self-aware");
	print("okay I get the point of printing messages.");
	print("yeet");
	print(scoreValue);
	}
	
	// Update is called once per frame
	void Update ()
	{
		print(stringNum);
	}
}
