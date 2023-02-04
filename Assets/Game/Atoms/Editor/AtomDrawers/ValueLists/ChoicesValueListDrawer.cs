#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Choices`. Inherits from `AtomDrawer&lt;ChoicesValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ChoicesValueList))]
    public class ChoicesValueListDrawer : AtomDrawer<ChoicesValueList> { }
}
#endif
