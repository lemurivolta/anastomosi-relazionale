using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Choices`. Inherits from `AtomVariableInstancer&lt;ChoicesVariable, ChoicesPair, Choices, ChoicesEvent, ChoicesPairEvent, ChoicesChoicesFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Choices Variable Instancer")]
    public class ChoicesVariableInstancer : AtomVariableInstancer<
        ChoicesVariable,
        ChoicesPair,
        Choices,
        ChoicesEvent,
        ChoicesPairEvent,
        ChoicesChoicesFunction>
    { }
}
