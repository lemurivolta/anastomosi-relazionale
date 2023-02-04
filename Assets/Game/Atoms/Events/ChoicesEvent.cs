using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Choices`. Inherits from `AtomEvent&lt;Choices&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Choices", fileName = "ChoicesEvent")]
    public sealed class ChoicesEvent : AtomEvent<Choices>
    {
    }
}
