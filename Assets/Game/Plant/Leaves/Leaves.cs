using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Leaves : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] _leavesRenderes;

    [System.Serializable]
    public struct LeafVariants {
        public Sprite[] Variants;
    }

    [SerializeField] LeafVariants[] _leavesVariants;

    [SerializeField] Color[] _leavesColors;

    private void Start()
    {
        Assert.IsNotNull(_leavesRenderes);
        Assert.IsNotNull(_leavesVariants);

        Assert.AreEqual(_leavesRenderes.Length, _leavesVariants.Length);
    }

    private void ApplyChoice(int seed)
    {
        var r = new System.Random(seed);

        var leafIndex = r.Next(0, _leavesRenderes.Length);
        var leafRenderer = _leavesRenderes[leafIndex];
        var leafVariants = _leavesVariants[leafIndex];
        var leafVariant = leafVariants.Variants[r.Next(0, leafVariants.Variants.Length)];

        leafRenderer.sprite = leafVariant;

        leafRenderer.color = _leavesColors[r.Next(0, _leavesColors.Length)];
    }

    private string _lastNodeNameSelected;
    private int _lastAction;

    public void NodeSelected(string nodeName)
    {
        if (!string.IsNullOrEmpty(nodeName))
        {
            _lastNodeNameSelected = nodeName;
        }
    }

    public void NodeAction(int index)
    {
        _lastAction = index;
    }

    public void NodeEnded()
    {
        Debug.Log($"Leaves remembered node {_lastNodeNameSelected} and action {_lastAction}");
        ApplyChoice(_lastNodeNameSelected.GetHashCode() + _lastAction);
    }
}
