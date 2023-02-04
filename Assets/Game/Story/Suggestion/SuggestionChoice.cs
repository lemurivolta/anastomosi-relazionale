using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

public class SuggestionChoice : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private TextMeshProUGUI _tmPro;

    [SerializeField] private StoryNodes _storyNodes;

    [SerializeField] private ColorConstant _baseColor;
    [SerializeField] private ColorConstant _hoverColor;

    private string _currentNode;

    [SerializeField] private StoryNodes.ActionKind _actionKind;

    private void Start()
    {
        Assert.IsNotNull(_storyNodes);
        _tmPro = GetComponentInChildren<TextMeshProUGUI>();
        Assert.IsNotNull(_tmPro);
        _tmPro.color = _baseColor.Value;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _tmPro.color = _hoverColor.Value;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _tmPro.color = _baseColor.Value;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _storyNodes.ChooseStory(_currentNode, _actionKind);
    }

    public void OnNodeSelected(string nodeName)
    {
        Debug.Log("OnNodeSelected");
        _currentNode = nodeName;
    }
}
