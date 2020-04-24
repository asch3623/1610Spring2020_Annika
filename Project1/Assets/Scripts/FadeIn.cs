using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    private SpriteRenderer render;
    void Start()
    {
       render = GetComponent<SpriteRenderer>();
    }

    IEnumerator fadeIn()
    {
        for (float f = 0.05f; f <= 1; f += 0.1f)
        {
            Color c = render.material.color;
            c.a = f;
            render.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        Color c = render.material.color;
        c.a = 0f;
        render.material.color = c;
        StartCoroutine("fadeIn");
    }
}
