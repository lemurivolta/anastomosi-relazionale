using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

public class UpdateNodeText : MonoBehaviour
{
    [System.Serializable]
    public enum Kind {
        Suggestion,
        Description
    };

    [SerializeField] StoryNodes _storyNodes;
    [SerializeField] Kind _kind;

    private TextMeshProUGUI _tmpro;

    private void Start()
    {
        Assert.IsNotNull(_storyNodes);
        _tmpro = GetComponent<TextMeshProUGUI>();
        Assert.IsNotNull(_tmpro);
    }

    private string _hoveredNode;
    private string _selectedNode;

    public void NodeHovered(string nodeName)
    {
        _hoveredNode = nodeName;
        UpdateText();
    }

    public void NodeSelected(string nodeName)
    {
        _selectedNode = nodeName;
        UpdateText();
    }

    private string GetText(string n)
    {
        switch(_kind)
        {
            case Kind.Description: return _storyNodes.GetNodeDescription(n);
            case Kind.Suggestion: return _storyNodes.GetNodeSuggestion(n);
            default: throw new System.Exception("Unknown kind");
        }
    }

    private void UpdateText()
    {
        var text = "";
        if (!string.IsNullOrEmpty(_selectedNode))
        {
            text = GetText(_selectedNode);
        }
        else if (!string.IsNullOrEmpty(_hoveredNode))
        {
            text = GetText(_hoveredNode);
        }
        _tmpro.text = text;
    }
}
