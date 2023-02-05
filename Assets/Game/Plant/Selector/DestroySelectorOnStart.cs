using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class DestroySelectorOnStart : MonoBehaviour
{
    [SerializeField] private PlantSelectorSpriteMouseHover _plantSelector;

    public string NodeName => _plantSelector.NodeName;

    private void Start()
    {
        Assert.IsNotNull(_plantSelector);
    }

    public void NodeStarted(string name)
    {
        if(_plantSelector.NodeName == name)
        {
            Destroy(gameObject);
        }
    }
}
