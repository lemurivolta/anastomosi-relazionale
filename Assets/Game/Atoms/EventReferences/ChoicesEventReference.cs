using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Choices`. Inherits from `AtomEventReference&lt;Choices, ChoicesVariable, ChoicesEvent, ChoicesVariableInstancer, ChoicesEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ChoicesEventReference : AtomEventReference<
        Choices,
        ChoicesVariable,
        ChoicesEvent,
        ChoicesVariableInstancer,
        ChoicesEventInstancer>, IGetEvent 
    { }
}
