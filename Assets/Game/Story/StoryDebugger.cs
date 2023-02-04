using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryDebugger : MonoBehaviour
{
    [SerializeField] private StoryNodes _storyNodes;

    public void DebugPrintNode1Suggestion()
    {
        Debug.Log(_storyNodes.GetNodeSuggestion("Node1"));
    }
}
