using DataTypes;
using UnityEngine;

public class GravityChangers : MonoBehaviour
{
    private SpriteRenderer mysprite;
    public BoolData isGrounded;
    private Transform groundCollider;

    public BoolData isFlipped;

    private Transform spriteTrans;
    void Start()
    {
        mysprite = GetComponent<SpriteRenderer>();
        spriteTrans = GetComponent<Transform>();
        groundCollider = GetComponentInChildren<Transform>();
        isFlipped.value = false;
    }
    
    void Update()
    {
        //flip sprite
        if (isFlipped.value == false)
        {
            var temp = Physics2D.gravity;
            temp.y = -19.81f;
            Physics2D.gravity = temp;
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
             {
                        mysprite.flipX = false;
                        return;
             } 
             if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
             {
                        mysprite.flipX = true;
                        return;
             }
        }

        if (isFlipped.value)
        {
             if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
             {
                        mysprite.flipX = true;
                        return;
             }
             if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
             {
                        mysprite.flipX = false;
                        return;
             }
        }
       
        
        
        //flip gravity
        if ( isGrounded.value)
        {
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
               groundCollider.rotation = Quaternion.Euler(0, 0, 0);
               
               var temp = Physics2D.gravity;
               temp.y = -19.81f;
               Physics2D.gravity = temp;
                           isFlipped.value = false;
                           if (mysprite.flipX == false)
                           {
                               mysprite.flipX = true;
                               return;
                           }
                           if (mysprite.flipX)
                           {
                               mysprite.flipX = false;
                               return;
                           }      
                           
                           return;
            }
            
            if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
            {
                groundCollider.rotation = Quaternion.Euler(0, 0, -180);
                var temp = Physics2D.gravity;
                            temp.y = 19.81f;
                            Physics2D.gravity = temp;
                            isFlipped.value = true;
                            if (mysprite.flipX == false)
                            {
                                mysprite.flipX = true;
                                return;
                            }
                            if (mysprite.flipX)
                            {
                                mysprite.flipX = false;
                            }      
            }
            
        }
    }
    }

