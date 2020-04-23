using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]

public class CubeMoveHorizontal : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 6f;
    public float jumpForce = 30f;
    public int jumpCountMax = 2;
    public int jumpCount;
    public float gravity = -3f;

    public UnityEvent jumpEvent;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(positionDirection * Time.deltaTime);
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        positionDirection.y = gravity;
       

        if (controller.isGrounded)
        {
            jumpCount = 0;
            positionDirection.y = positionDirection.y;
        }
        
        //double jump
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        
        //gravity
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("going Up");
            positionDirection.y = 3f;
            jumpForce = -30f;

        }
        
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("going down");
            positionDirection.y = gravity;

            jumpForce = 30f;
        }
        
        
    }
}
