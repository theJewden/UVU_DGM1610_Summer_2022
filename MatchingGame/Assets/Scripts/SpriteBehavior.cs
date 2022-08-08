using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ID obj)
    {
        spriteRenderer.color = obj.color;
    }

    public void ChangeRendererColor(ColorList obj)
    {
        spriteRenderer.color = obj.currentColor.color;
    }
}
