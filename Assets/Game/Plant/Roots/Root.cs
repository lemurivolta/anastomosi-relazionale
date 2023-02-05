using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Root : MonoBehaviour
{
    [SerializeField] private float _fadeInDuration;

    public void SetSprite(Sprite sprite)
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        Assert.IsNotNull(spriteRenderer);
        spriteRenderer.sprite = sprite;
        spriteRenderer.DOColor(Color.white, _fadeInDuration);
    }
}
