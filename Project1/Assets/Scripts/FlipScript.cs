using UnityEngine;

public class FlipScript : MonoBehaviour
{
    public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow;

    public float direction1 = 0, direction2 = -180;
    void Update()
    {
        if (Input.GetKeyDown(key1)|| Input.GetKeyDown(KeyCode.A))
        {
           transform.rotation = Quaternion.Euler(0,direction2,0);
        } 
        if (Input.GetKeyDown(key2)||Input.GetKeyDown(KeyCode.D))
        {
             transform.rotation = Quaternion.Euler(0,direction1,0);
        } 
    }

    public void Flip(float value)
    {
        transform.Rotate (0,value,0);
    }
}
