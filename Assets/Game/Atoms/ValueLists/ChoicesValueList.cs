using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Choices`. Inherits from `AtomValueList&lt;Choices, ChoicesEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Choices", fileName = "ChoicesValueList")]
    public sealed class ChoicesValueList : AtomValueList<Choices, ChoicesEvent> { }
}
