using System;
using System.Collections;
using System.Collections.Generic;
using DataTypes;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    public IntData starCount;
    private Collider2D col;
    public Text end;
    private SpriteRenderer thisSprite;
    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        col.enabled = false;
        end.enabled = false;
        thisSprite.enabled = true;


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        openDoor(other);
    }

    void Update()
    {
        if (starCount.value == 4)
        {
            col.enabled = true;
            thisSprite.enabled = false;
        }
    }

    public void openDoor(Collider2D player)
    {
        end.enabled = true;
    }
    
}
