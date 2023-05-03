#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomDrawer&lt;SOTargetTypeValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOTargetTypeValueList))]
    public class SOTargetTypeValueListDrawer : AtomDrawer<SOTargetTypeValueList> { }
}
#endif
