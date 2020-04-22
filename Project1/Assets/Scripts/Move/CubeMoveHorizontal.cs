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

    public UnityEvent jumpEvent;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(positionDirection * Time.deltaTime);
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
       

        if (controller.isGrounded)
        {
            jumpCount = 0;
            positionDirection.y = 0;
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
            Physics.gravity = new Vector3(0f,9.81f,0f);
            jumpForce = -30f;

        }
        
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("going down");
            Physics.gravity = new Vector3(0f,-9.81f,0f);

            jumpForce = 30f;
        }
        
        
    }
}
