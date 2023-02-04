using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

public class SuggestionChoice : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI _tmPro;

    [SerializeField] private ColorConstant _baseColor;
    [SerializeField] private ColorConstant _hoverColor;

    private void Start()
    {
        _tmPro = GetComponent<TextMeshProUGUI>();
        Assert.IsNotNull(_tmPro);
        _tmPro.color = _baseColor.Value;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("On pointer enter");
        _tmPro.color = _hoverColor.Value;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("On pointer enter");
        _tmPro.color = _baseColor.Value;
    }

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
    }
}
