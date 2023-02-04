#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ChoicesPair`. Inherits from `AtomEventEditor&lt;ChoicesPair, ChoicesPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ChoicesPairEvent))]
    public sealed class ChoicesPairEventEditor : AtomEventEditor<ChoicesPair, ChoicesPairEvent> { }
}
#endif
