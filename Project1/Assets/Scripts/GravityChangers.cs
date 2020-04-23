using DataTypes;
using UnityEngine;

public class GravityChangers : MonoBehaviour
{
    private SpriteRenderer mysprite;
    public IntData collisionCounter;
    void Start()
    {
        mysprite = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mysprite.flipX = false;
        }
        
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            mysprite.flipX = true;
        }
        
        if ((Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow)) && collisionCounter.value == 1)
        {
            mysprite.flipY = true;
            var temp = Physics2D.gravity;
            temp.y = 19.81f;
            Physics2D.gravity = temp;
        }
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && collisionCounter.value == 1)
        {
            mysprite.flipY = false;
            var temp = Physics2D.gravity;
            temp.y = -19.81f;
            Physics2D.gravity = temp;
        }
    }
    }

