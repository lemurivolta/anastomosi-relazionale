using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Choices`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ChoicesVariable))]
    public sealed class ChoicesVariableEditor : AtomVariableEditor<Choices, ChoicesPair> { }
}
