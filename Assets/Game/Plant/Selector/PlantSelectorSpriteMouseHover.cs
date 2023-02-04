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
    private bool _hovered = false;

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
        _hovered = true;
        UpdateColor();
        _nodeHovered.Raise(_nodeName);
    }

    void OnMouseExit()
    {
        _hovered = false;
        UpdateColor();
        _nodeHovered.Raise("");
    }

    private void OnMouseDown()
    {
        _nodeSelected.Raise(_nodeName);
    }

    public void OnNodeSelected(string selectedNodeName)
    {
        _selected = _nodeName == selectedNodeName;
        UpdateColor();
    }

    private void UpdateColor()
    {
        _spriteRenderer.color = _selected ? _selectedColor.Value :
            _hovered ? _hoverColor.Value : _baseColor.Value;
    }
}
