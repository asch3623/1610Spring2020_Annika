using UnityEngine;

public class Practice : MonoBehaviour {

	public string myName = "Annika";

		double age = 10;
	void Start () {

		age = (float)10;

		var x = 10 + 4;

		Debug.Log(myName + " " + "Schwartz");
		print(x);
		print(age);

	}
	

	void Update () {

		if (myName == "Annika")
		{
			print("this is true");
		}
		else
		{
			print("this isn't true.");
		}
	}
}
