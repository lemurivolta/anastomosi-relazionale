using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Choices`. Inherits from `AtomEventReferenceListener&lt;Choices, ChoicesEvent, ChoicesEventReference, ChoicesUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Choices Event Reference Listener")]
    public sealed class ChoicesEventReferenceListener : AtomEventReferenceListener<
        Choices,
        ChoicesEvent,
        ChoicesEventReference,
        ChoicesUnityEvent>
    { }
}
