using UnityEngine;

public class GravityChangers : MonoBehaviour
{
    private SpriteRenderer mysprite;
    void Start()
    {
        mysprite = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
        {
            mysprite.flipY = true;
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            mysprite.flipY = false;
        }
    }
    }

