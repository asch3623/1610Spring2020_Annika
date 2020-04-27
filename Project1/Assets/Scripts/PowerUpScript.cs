using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float multiplier = 1.4f;
    private ParticleSystem particles;
    public float time = 3f;
    private SpriteRenderer spr;
    private Collider2D col;
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
        spr = GetComponent<SpriteRenderer>();
       col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(Pickup(other));
    }

    IEnumerator Pickup(Collider2D player)
    {
        player.transform.localScale *= multiplier;
        col.enabled = false;
        spr.enabled = false;
        
        yield return new WaitForSeconds(time);
        player.transform.localScale /= multiplier;
        Destroy(gameObject);
    }
}
