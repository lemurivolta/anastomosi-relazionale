using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ChoicesPair`. Inherits from `AtomEvent&lt;ChoicesPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ChoicesPair", fileName = "ChoicesPairEvent")]
    public sealed class ChoicesPairEvent : AtomEvent<ChoicesPair>
    {
    }
}
