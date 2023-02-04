using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ChoicesPair`. Inherits from `AtomEventReferenceListener&lt;ChoicesPair, ChoicesPairEvent, ChoicesPairEventReference, ChoicesPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ChoicesPair Event Reference Listener")]
    public sealed class ChoicesPairEventReferenceListener : AtomEventReferenceListener<
        ChoicesPair,
        ChoicesPairEvent,
        ChoicesPairEventReference,
        ChoicesPairUnityEvent>
    { }
}
