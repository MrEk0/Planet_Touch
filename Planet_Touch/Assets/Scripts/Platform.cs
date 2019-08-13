//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour, IClickable
{
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name=="Ball")
        {
            spriteRenderer.color = RandomColor();
        }
    }

    private Color RandomColor()
    {
        float green = Random.Range(0, 255);
        float blue = Random.Range(0, 255);
        float red = Random.Range(0, 255);

        Color color = new Color(red / 255, green / 255, blue / 255);

        return color;
    }

    public void Click()
    {
        spriteRenderer.color = RandomColor();
    }
}
