using UnityEngine;

public class Practice : MonoBehaviour
{
[SerializeField]
	private Transform damagePopUp;
	 void Start()
	 {
	Transform damagePopupTransform = Instantiate(damagePopUp, Vector3.zero, Quaternion.identity);
	DamagePopUp damagePopUp = damagePopupTransform.GetComponent<DamagePopUp>();
	damagePopUp.SetUp(-5);

	 }
}
