using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    private SpriteRenderer mySprite;
    
    public Color myColor = Color.blue;

    public Color offColor = Color.green;

    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        mySprite.color = myColor;
    }

    private void OnEnable()
    {
        mySprite.color = myColor;
    }

    private void OnDisable()
    {
        mySprite.color = offColor;
    }

    void Update()
    {
        
    }
}
