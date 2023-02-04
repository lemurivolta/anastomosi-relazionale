#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Choices`. Inherits from `AtomDrawer&lt;ChoicesConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ChoicesConstant))]
    public class ChoicesConstantDrawer : VariableDrawer<ChoicesConstant> { }
}
#endif
