using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorsVisibility : MonoBehaviour
{
    [SerializeField] private Transform[] _selectors;

    public void OnNodeStarted()
    {
        SetAllActive(false);
    }

    public void OnNodeEnded()
    {
        SetAllActive(true);
    }

    private void SetAllActive(bool isActive)
    {
        foreach(var child in _selectors)
        {
            if (child != null && child.gameObject != null && child.TryGetComponent<DestroySelectorOnStart>(out _))
            {
                child.gameObject.SetActive(isActive);
            }
        }
    }
}
