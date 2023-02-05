using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Roots : MonoBehaviour
{
    [System.Serializable]
    public struct Entry
    {
        public StoryNodes.ActionKind ActionKind;
        public string NodeName;
        public Sprite OverlaySprite;
    }

    [SerializeField] private GameObject _rootPrefab;

    [SerializeField] private Entry[] Entries;

    private StoryNodes.ActionKind _lastAction;

    private void Start()
    {
        Assert.IsNotNull(_rootPrefab);
    }

    public void NodeAction(int index)
    {
        _lastAction = (StoryNodes.ActionKind)index;
    }

    public void NodeEnded(string nodeName)
    {
        foreach (var entry in Entries)
        {
            if (entry.ActionKind == _lastAction &&
                entry.NodeName == nodeName)
            {
                var rootGameObject = Instantiate(_rootPrefab, transform);
                var root = rootGameObject.GetComponent<Root>();
                root.SetSprite(entry.OverlaySprite);
                return;
            }
        }
        throw new System.Exception("cannot find matching root");
    }
}
