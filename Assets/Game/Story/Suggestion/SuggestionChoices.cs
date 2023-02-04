using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuggestionChoices : MonoBehaviour
{
    [SerializeField] private GameObject[] _suggestionChoices;

    public void NodeHovered(string nodeName)
    {
        var active = !string.IsNullOrWhiteSpace(nodeName);
        foreach (var choice in _suggestionChoices)
        {
            choice.SetActive(active);
        }
    }
}
