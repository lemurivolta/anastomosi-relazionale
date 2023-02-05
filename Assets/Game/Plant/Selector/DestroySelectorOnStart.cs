using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Assertions;

public class DestroySelectorOnStart : MonoBehaviour
{
    [SerializeField] private PlantSelectorSpriteMouseHover _plantSelector;

    [SerializeField] private VoidEvent _allNodesExplored;

    public string NodeName => _plantSelector.NodeName;

    private void Start()
    {
        Assert.IsNotNull(_plantSelector);
    }

    public void NodeStarted(string name)
    {
        if(transform.parent.childCount == 1)
        {
            // we are the last one
            _allNodesExplored.Raise();
        }
        if(_plantSelector.NodeName == name)
        {
            Destroy(gameObject);
        }
    }
}
