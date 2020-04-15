using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    //tutorial from https://www.youtube.com/watch?v=MoaFVfb9ksw

    public Transform player;
    public float speed = 5f;
    public GameObject bullet;
    
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetKeyDown("space"))
        {
            shootBullet();
        }
    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction*speed*Time.deltaTime);
    }

    public void shootBullet()
    {
        GameObject laser = Instantiate(bullet) as GameObject;
        laser.transform.position = player.transform.position;
    }
}
