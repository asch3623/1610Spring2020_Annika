using UnityEngine;

public class SpriteMove : MonoBehaviour
{
    // code from Kyle Suchar https://www.youtube.com/watch?v=L6Q6VHueWnU
    public float speed = 6f;
    public bool isGrounded = false;

    void Start()
    {
     
    }

    // code from Kyle Suchar https://www.youtube.com/watch?v=L6Q6VHueWnU
    void Update()
    {
        JumpAction();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

         void JumpAction()
        {
            if (Input.GetButtonDown("Jump") && isGrounded == true)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            }
        }
    }
}

