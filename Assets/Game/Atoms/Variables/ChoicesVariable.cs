using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Choices`. Inherits from `EquatableAtomVariable&lt;Choices, ChoicesPair, ChoicesEvent, ChoicesPairEvent, ChoicesChoicesFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Choices", fileName = "ChoicesVariable")]
    public sealed class ChoicesVariable : EquatableAtomVariable<Choices, ChoicesPair, ChoicesEvent, ChoicesPairEvent, ChoicesChoicesFunction>
    {
    }
}
