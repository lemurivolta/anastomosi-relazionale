using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CompleteFlowerAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 _finalPosition;
    [SerializeField] private float _duration;

    public void OnStoryComplete()
    {
        transform.DOMove(_finalPosition, _duration);
    }
}
