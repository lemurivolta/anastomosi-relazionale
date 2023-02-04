#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Choices`. Inherits from `AtomDrawer&lt;ChoicesVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ChoicesVariable))]
    public class ChoicesVariableDrawer : VariableDrawer<ChoicesVariable> { }
}
#endif
