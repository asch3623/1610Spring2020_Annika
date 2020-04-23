using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class SpriteMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 20f;
    private float maxVelocity = 5f;
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    //code help from https://www.youtube.com/watch?v=z3zQuLhnqGE
    void Update()
    {
        var xdiff = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
       

        if (Mathf.Abs(rb2d.velocity.x) > maxVelocity)
        {
            var temp = rb2d.velocity;
            temp.x = maxVelocity * Mathf.Sign(xdiff);
            rb2d.velocity = temp;
            return;
        }
        rb2d.AddForce(Vector2.right*xdiff, ForceMode2D.Impulse);
    }
    
    
}


