using DataTypes;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class SpriteMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 10f;
    private Transform player;
    private Animator anim;

    public bool isGrounded;
    public float jumpPower;
    public LayerMask ground;
    public BoolData collisionCheck;
    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        player = GetComponent<Transform>();
    }

    //code help from https://www.youtube.com/watch?v=z3zQuLhnqGE
    void Update()
    {

       isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
            new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f), ground);
        
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);

        player.rotation = Quaternion.Euler(0f, 0f, 0f);
        
        
//jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2d.AddForce(Vector2.up*jumpPower, ForceMode2D.Impulse);
        }

        if (isGrounded)
        {
            collisionCheck.value = true;
        }
        else
        {
            collisionCheck.value = false;
        }
        
        
//animation        

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }
}


