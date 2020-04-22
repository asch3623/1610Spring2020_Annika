using System;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class GravityController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector2 moveVelocity;
    public int collisions = 0;

void OnCollisionEnter(Collision collision)
{
    if (collision.collider.tag == "Ground")
    {
        collisions++;
    }
  
}

void OnCollisionExit(Collision collision)

{
    if (collision.collider.tag == "Ground")
    {
        collisions--;
    }
}
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);

        moveVelocity = moveInput.normalized * speed;
    }
    private void FixedUpdate()
    {
        
    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

   if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && collisions > 0)
        {
            rb.gravityScale = -100;
        }  
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && collisions == 0)
        {
            rb.gravityScale = 100;
        }  
    }
}
