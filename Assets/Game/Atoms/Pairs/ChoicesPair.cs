using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Choices&gt;`. Inherits from `IPair&lt;Choices&gt;`.
    /// </summary>
    [Serializable]
    public struct ChoicesPair : IPair<Choices>
    {
        public Choices Item1 { get => _item1; set => _item1 = value; }
        public Choices Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Choices _item1;
        [SerializeField]
        private Choices _item2;

        public void Deconstruct(out Choices item1, out Choices item2) { item1 = Item1; item2 = Item2; }
    }
}