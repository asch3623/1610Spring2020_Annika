using System.Collections;
using TMPro;
using UnityEngine;

public class Practice : MonoBehaviour
{
	public Transform player;
	private Vector3 playerLocation;
	public TextMeshPro dam;

	 void Start()
	 {
		 playerLocation = player.position;
	 }

	 private void OnTriggerEnter2D(Collider2D other)
	 {
		 if (other.CompareTag("Player"))
		 {
			Create(dam.ToString());
		 }
	 }
	 
	  void Create(string text)
	 {
		 Instantiate(dam, playerLocation += new Vector3(0, 5, 0), Quaternion.identity);
		 


	 }
}
