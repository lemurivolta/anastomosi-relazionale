using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Anastomosi/Create Story")]
public class StoryNodes : ScriptableObject
{
    [System.Serializable]
    public enum ActionKind
    {
        Solve,
        Coagula,
        Amalgama
    }

    [SerializeField] private TextAsset _inkTextAsset;

    private int _textHash = -1;

    private Story _story;

    private Story story
    {
        get
        {
            var hash = _inkTextAsset.text.GetHashCode();
            if(_textHash != hash || _story == null)
            {
                _textHash = hash;
                _story = new Story(_inkTextAsset.text);
            }
            return _story;
        }
    }

    public string GetNodeSuggestion(string nodeName) =>
        GetLabelledTag(nodeName, "suggestion:");

    public string GetNodeDescription(string nodeName) =>
        GetLabelledTag(nodeName, "description:");

    private string GetLabelledTag(string nodeName, string label)
    {
        var tags = story.TagsForContentAtPath(nodeName);
        var labelTags = tags
            .Select(tag => tag.Trim())
            .Where(tag => tag.StartsWith(label))
            .Select(tag => tag.Substring(label.Length).Trim())
            .ToArray();
        if (labelTags.Length != 1)
        {
            throw new System.Exception($"Expected 1 '{label}' tag for node {nodeName}, found {labelTags.Length}");
        }
        return labelTags[0];
    }

    public void ChooseStory(string nodeName, ActionKind actionKind)
    {
        story.ChoosePathString(nodeName);
        story.Continue();
        string tag;
        switch (actionKind)
        {
            case ActionKind.Coagula: tag = "coagula"; break;
            case ActionKind.Amalgama: tag = "amalgama"; break;
            case ActionKind.Solve: tag = "solve"; break;
            default: throw new System.Exception("Unknown tag");
        }
        foreach(var choice in story.currentChoices)
        {
            if(choice.tags.Contains(tag))
            {
                story.ChooseChoiceIndex(choice.index);
                story.Continue();
                return;
            }
        }
        throw new System.Exception("cannot find choice with correct action");
    }
}
