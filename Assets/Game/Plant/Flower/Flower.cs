using DG.Tweening;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Flower : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] _flowersRenderes;

    [System.Serializable]
    public struct FLowerVariants
    {
        public Sprite[] Variants;
    }

    [SerializeField] FLowerVariants[] _flowersVariants;

    [SerializeField] Color[] _flowersColors;

    private Dictionary<string, int> nodesToChoice = new();

    private int _lastNodeAction;

    public void NodeStarted(string nodeName)
    {
        nodesToChoice[nodeName] = _lastNodeAction;
    }

    public void NodeAction(int index)
    {
        _lastNodeAction = index;
    }

    [SerializeField] private int _numPassageColors;
    [SerializeField] private float _timeBetweenPassageColors;

    public void OnAllNodesExplored()
    {
        // compute seed from all choices
        var namesList = nodesToChoice.Keys.ToList();
        namesList.Sort();

        var seed = 0;
        foreach(var name in namesList)
        {
            seed += $"{name} - {nodesToChoice[name]}".GetHashCode();
        }

        var r = new System.Random(seed);

        // create random flower
        for (var flowerIndex = 0; flowerIndex < _flowersRenderes.Length; flowerIndex++)
        {
            var flowerRenderer = _flowersRenderes[flowerIndex];
            var flowerVariants = _flowersVariants[flowerIndex];
            var flowerVariant = flowerVariants.Variants[r.Next(0, flowerVariants.Variants.Length)];

            flowerRenderer.sprite = flowerVariant;

            var sequence = DOTween.Sequence();
            for(var i = 0; i < _numPassageColors; i++)
            {
                var color = _flowersColors[r.Next(0, _flowersColors.Length)];
                Debug.Log($"tweening color to {color}");
                sequence.Append(flowerRenderer.DOColor(color, _timeBetweenPassageColors));
            }
        }
    }
}
