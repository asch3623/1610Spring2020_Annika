using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class CubeMove : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 6f;
    public float gravity = 3f;
    public float jumpForce = 30f;
    public int jumpCountMax = 2;
    public static double jumpCount;
    void Start()
    {
        
    }

    void Update()
    {
        controller.Move(positionDirection * Time.deltaTime);
        positionDirection.x = Input.GetAxis("Vertical")*speed;
        positionDirection.z = Input.GetAxis("Horizontal")*-speed;
        positionDirection.y -= gravity;

        if (controller.isGrounded)
        {
            jumpCount = 0;
            positionDirection.y = 0;
        }
        
        //double jump
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
    }
}
