using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Choices`. Inherits from `SetVariableValue&lt;Choices, ChoicesPair, ChoicesVariable, ChoicesConstant, ChoicesReference, ChoicesEvent, ChoicesPairEvent, ChoicesVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Choices", fileName = "SetChoicesVariableValue")]
    public sealed class SetChoicesVariableValue : SetVariableValue<
        Choices,
        ChoicesPair,
        ChoicesVariable,
        ChoicesConstant,
        ChoicesReference,
        ChoicesEvent,
        ChoicesPairEvent,
        ChoicesChoicesFunction,
        ChoicesVariableInstancer>
    { }
}
