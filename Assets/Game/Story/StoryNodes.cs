using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
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

    [SerializeField] private StringEvent _lineEvent;

    [SerializeField] private ChoicesEvent _choicesEvent;

    [SerializeField] private VoidEvent _advanceEvent;

    [SerializeField] private IntEvent _makeChoiceEvent;

    [SerializeField] private StringEvent _nodeStartedEvent;

    [SerializeField] private StringEvent _nodeEndedEvent;

    [SerializeField] private IntEvent _nodeActionEvent;

    [SerializeField] private VoidEvent _allNodesExploredEvent;

    private int _textHash = -1;

    private Story _story;

    private List<string> _nodesYetToVisit;

    private Story Story
    {
        get
        {
            var hash = _inkTextAsset.text.GetHashCode();
            if (_textHash != hash || _story == null)
            {
                _textHash = hash;
                _story = new Story(_inkTextAsset.text);
                _mustSendChoices = false;
                _story.onDidContinue += StoryOnDidContinue;
                _advanceEvent.Register(AdvanceEventRaised);
                _makeChoiceEvent.Register(MakeChoice);

                _nodesYetToVisit = new();
                var namedContent = _story.mainContentContainer.namedContent.Keys;
                foreach (var content in namedContent)
                {
                    try
                    {
                        GetNodeSuggestion(content);
                        _nodesYetToVisit.Add(content);
                    }
                    catch
                    {
                        // throws exception if there's no suggestion tag
                    }
                }
            }
            return _story;
        }
    }

    private bool _mustSendChoices = false;

    private void Awake()
    {
        _mustSendChoices = false;
    }

    private void StoryOnDidContinue()
    {
        if (Story.currentChoices.Count > 0)
        {
            if (_mustSendChoices)
            {
                _choicesEvent.Raise(new Choices()
                {
                    Lines = Story.currentChoices.Select(l => l.text).ToArray()
                });
                _mustSendChoices = false;
            }
            else
            {
                _lineEvent.Raise(Story.currentText);
                _mustSendChoices = true;
            }
        }
        else
        {
            _lineEvent.Raise(Story.currentText);
        }
    }

    private string _currentNode = "";

    private void AdvanceEventRaised()
    {
        if (_mustSendChoices)
        {
            StoryOnDidContinue();
        }
        else if (Story.canContinue)
        {
            Story.Continue();
        }
        else
        {
            _nodeEndedEvent.Raise(_currentNode);
            _nodesYetToVisit.Remove(_currentNode);
            _currentNode = "";
            if (_nodesYetToVisit.Count == 0)
            {
                _allNodesExploredEvent.Raise();
            }
        }
    }

    private void MakeChoice(int choiceNumber)
    {
        Story.ChooseChoiceIndex(choiceNumber);
    }

    public string GetNodeSuggestion(string nodeName) =>
        GetLabelledTag(nodeName, "suggestion:");

    public string GetNodeDescription(string nodeName) =>
        GetLabelledTag(nodeName, "description:");

    private string GetLabelledTag(string nodeName, string label)
    {
        var tags = Story.TagsForContentAtPath(nodeName);
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
        _currentNode = nodeName;
        Story.ChoosePathString(nodeName);
        Story.Continue();
        string tag = actionKind switch
        {
            ActionKind.Coagula => "coagula",
            ActionKind.Amalgama => "amalgama",
            ActionKind.Solve => "solve",
            _ => throw new System.Exception("Unknown tag"),
        };
        _nodeActionEvent.Raise((int)actionKind);
        foreach (var choice in Story.currentChoices)
        {
            if (choice.tags.Contains(tag))
            {
                Story.ChooseChoiceIndex(choice.index);
                _mustSendChoices = false;
                Story.Continue();
                _nodeStartedEvent.Raise(nodeName);
                return;
            }
        }
        throw new System.Exception("cannot find choice with correct action");
    }
}
