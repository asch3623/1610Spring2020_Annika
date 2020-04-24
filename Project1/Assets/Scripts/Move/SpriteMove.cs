using DataTypes;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class SpriteMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 15f;
    private Transform player;
    private Animator anim;
    
    
    public float jumpPower;
   
    public BoolData collisionCheck;
    public BoolData isFlipped;
    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        player = GetComponent<Transform>();
    }

    //code help from https://www.youtube.com/watch?v=z3zQuLhnqGE
    void Update()
    {
        
        
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);

        player.rotation = Quaternion.Euler(0f, 0f, 0f);
        
        
//jump
        if (Input.GetKeyDown(KeyCode.Space) && collisionCheck.value)
        {
            if (isFlipped.value == false)
            {
                rb2d.velocity = Vector2.up * jumpPower;
            }
            else
            {
                rb2d.velocity = Vector2.up * -jumpPower;
            }
            
            anim.SetTrigger("TakeOff");
        } else{
        anim.SetBool("isJumping", true);
        }
        if (collisionCheck.value == true)
        {
         anim.SetBool("isJumping", false);
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


