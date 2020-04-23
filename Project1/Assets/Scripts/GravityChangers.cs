using DataTypes;
using UnityEngine;

public class GravityChangers : MonoBehaviour
{
    private SpriteRenderer mysprite;
    public BoolData isGrounded;
    private Transform groundCollider;

    public bool isFlipped;

    private Transform spriteTrans;
    void Start()
    {
        mysprite = GetComponent<SpriteRenderer>();
        spriteTrans = GetComponent<Transform>();
        groundCollider = GetComponentInChildren<Transform>();
    }
    
    void Update()
    {
        //flip sprite
        if (isFlipped == false)
        {
             if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
             {
                        mysprite.flipX = false;
                        return;
             } 
             if((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && isFlipped == false)
             {
                        mysprite.flipX = true;
                        return;
             }
        }

        if (isFlipped)
        {
             if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && isFlipped)
             {
                        mysprite.flipX = true;
                        return;
             }
             if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && isFlipped )
             {
                        mysprite.flipX = false;
                        return;
             }
        }
       
        
        
        //flip gravity
        if ( isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
               groundCollider.rotation = Quaternion.Euler(0, 0, 0);
                           var temp = Physics2D.gravity;
                           temp.y = -19.81f;
                           Physics2D.gravity = temp;
                           isFlipped = false;
                           return;
            }
            
            if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
            {
                groundCollider.rotation = Quaternion.Euler(0, 0, -180);
                            var temp = Physics2D.gravity;
                            temp.y = 19.81f;
                            Physics2D.gravity = temp;
                            isFlipped = true;
            }
            
        }
    }
    }

