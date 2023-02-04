using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

public class PlantSelectorSpriteMouseHover : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    [SerializeField] private ColorConstant _baseColor;
    [SerializeField] private ColorConstant _hoverColor;
    [SerializeField] private ColorConstant _selectedColor;

    [SerializeField] private string _nodeName;

    [SerializeField] private StringEvent _nodeHovered;

    [SerializeField] private StringEvent _nodeSelected;

    private bool _selected = false;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Assert.IsNotNull(_spriteRenderer);
        Assert.IsNotNull(_nodeHovered);
        Assert.IsFalse(string.IsNullOrEmpty(_nodeName));
        _spriteRenderer.color = GetCurrentColor();
    }

    private Color GetCurrentColor() => _selected ? _selectedColor.Value : _baseColor.Value;

    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        _spriteRenderer.color = _hoverColor.Value;
        _nodeHovered.Raise(_nodeName);
    }

    void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        _spriteRenderer.color = GetCurrentColor();
        _nodeHovered.Raise("");
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        _nodeSelected.Raise(_nodeName);
    }

    public void OnNodeSelected(string selectedNodeName)
    {
        Debug.Log("OnNodeSelected");
        _selected = _nodeName == selectedNodeName;
    }
}
