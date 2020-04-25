using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SummonText : MonoBehaviour
{

	
	public GameObject dam;
	public TextMeshPro textMesh;
	private Color col;
	

	private void Start()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	 {
		 if (other.CompareTag("Enemy"))
		 {
			 if (dam)
			 {
				 ChangeValue(-5);
					Create(dam.ToString()); 
			 }
		
		 }

		 if (other.CompareTag("PowerUp"))
		 {
			 if (dam)
			 {
				 ChangeValue(5);
				 Create(dam.ToString()); 
			 }
		 }
	 }
	 
	  void Create(string text)
	 { if (textMesh.text == "5")
		 {
			
      			 col = Color.green; 
                 textMesh.color = col;
                 
             }
      		 if (textMesh.text == "-5")
      		 {
      			 col = Color.red;
                 textMesh.color = col;
                 
             }
		 Instantiate(dam, transform.position + new Vector3(6,6,0), Quaternion.identity, transform);
		
		 
	 }

	  void ChangeValue(int amount)
	  {
		 textMesh.SetText(amount.ToString());
	  }
}
