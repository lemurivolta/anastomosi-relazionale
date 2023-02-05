using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuggestionVisibility : MonoBehaviour
{
    [SerializeField] private GameObject _suggestion;

    public void NodeStarted()
    {
        _suggestion.SetActive(false);
    }

    public void NodeEnded()
    {
        _suggestion.SetActive(true);
    }
}
