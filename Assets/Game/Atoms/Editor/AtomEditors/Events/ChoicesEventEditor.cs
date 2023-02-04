#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Choices`. Inherits from `AtomEventEditor&lt;Choices, ChoicesEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ChoicesEvent))]
    public sealed class ChoicesEventEditor : AtomEventEditor<Choices, ChoicesEvent> { }
}
#endif
