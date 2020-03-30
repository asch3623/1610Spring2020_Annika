using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private GameObject Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    void Update()
    {

    }
// code from Kyle Suchar https://www.youtube.com/watch?v=L6Q6VHueWnU
    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider>().tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider>().tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = false;
        }
    }
}
