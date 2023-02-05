using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

public class ChoiceContainer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    [SerializeField] private ColorConstant _baseColor;
    [SerializeField] private ColorConstant _hoverColor;

    private void Start()
    {
        Assert.IsNotNull(_textMeshPro);

        SetText("prova di testo", 1);
    }

    private int _index = -1;

    public void SetText(string text, int index)
    {
        _index = index;

        _textMeshPro.text = text;
        var rt = GetComponent<RectTransform>();
        rt.offsetMin = new Vector2(rt.offsetMin.x, -(_textMeshPro.preferredHeight + 4));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer enter");
        _textMeshPro.color = _hoverColor.Value;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _textMeshPro.color = _baseColor.Value;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"Choosing {_index}");
    }
}
