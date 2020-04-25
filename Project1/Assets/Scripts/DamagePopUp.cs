using System;
using TMPro;
using UnityEngine;

public class DamagePopUp : MonoBehaviour
{
    private TextMeshPro textMesh;

    public static DamagePopUp Create()
    {
        Transform damagePopupTransform = Instantiate(damagePopUp, Vector3.zero, Quaternion.identity);
        DamagePopUp damagePopUp = damagePopupTransform.GetComponent<DamagePopUp>();
        damagePopUp.SetUp(-5);
    }
    void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    public void SetUp(int damageAmount)
    {
        textMesh.SetText(damageAmount.ToString());
    }
}
