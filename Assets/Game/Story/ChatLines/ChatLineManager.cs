using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatLineManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tmPro;
    [SerializeField] private TextMeshProUGUI _nameTmPro;

    public void SetText(string text)
    {
        _tmPro.text = text;
    }

    public float TotalHeight 
    {
        get => _nameTmPro.preferredHeight + _tmPro.preferredHeight;
    }
}
