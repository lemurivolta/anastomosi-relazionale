using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ChoicesPair`. Inherits from `AtomEventReference&lt;ChoicesPair, ChoicesVariable, ChoicesPairEvent, ChoicesVariableInstancer, ChoicesPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ChoicesPairEventReference : AtomEventReference<
        ChoicesPair,
        ChoicesVariable,
        ChoicesPairEvent,
        ChoicesVariableInstancer,
        ChoicesPairEventInstancer>, IGetEvent 
    { }
}
