using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorsVisibility : MonoBehaviour
{
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
        for(var i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            if (child.TryGetComponent<DestroySelectorOnStart>(out _))
            {
                child.gameObject.SetActive(isActive);
            }
        }
    }
}
