using TMPro;
using UnityEngine;

public class DamagePopUp : MonoBehaviour
{
    private TextMeshPro textMesh;
    private Color textColor;
    private static float disappearTimer;
    private const float TIMER_MAX = 1f;
    private Vector3 moveVector;
    
    
    
//creates popup, from https://www.youtube.com/watch?v=iD1_JczQcFY
   
    void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
        SetUp(-5);
    }

    public void SetUp(int damageAmount)
    {
        textMesh.SetText(damageAmount.ToString());
        textColor = textMesh.color;
        disappearTimer = TIMER_MAX;
        moveVector = new Vector3(1,1) * 30f;
    }


    void Update()
    {

        disappearTimer -= Time.deltaTime;
        if (disappearTimer < 0)
        {
            float disappearSpeed = 1f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            textMesh.color = textColor;
        }

        if (textColor.a <= 0)
        {
            Destroy(textMesh);
        }
    }
    
}
