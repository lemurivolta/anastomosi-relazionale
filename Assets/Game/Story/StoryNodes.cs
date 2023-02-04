using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Anastomosi/Create Story")]
public class StoryNodes : ScriptableObject
{
    [SerializeField] private TextAsset _inkTextAsset;

    private int _textHash = -1;

    private Story _story;

    private Story story
    {
        get
        {
            var hash = _inkTextAsset.text.GetHashCode();
            if(_textHash != hash)
            {
                _textHash = hash;
                _story = new Story(_inkTextAsset.text);
            }
            return _story;
        }
    }

    public string GetNodeSuggestion(string nodeName)
    {
        const string suggestionLabel = "suggestion:";
        var tags = story.TagsForContentAtPath(nodeName);
        var suggestionTags = tags
            .Select(tag => tag.Trim())
            .Where(tag => tag.StartsWith(suggestionLabel))
            .Select(tag => tag.Substring(suggestionLabel.Length).Trim())
            .ToArray();
        if(suggestionTags.Length != 1)
        {
            throw new System.Exception($"Expected 1 suggestion tag for node {nodeName}, found {suggestionTags.Length}");
        }
        return suggestionTags[0];
    }

}
