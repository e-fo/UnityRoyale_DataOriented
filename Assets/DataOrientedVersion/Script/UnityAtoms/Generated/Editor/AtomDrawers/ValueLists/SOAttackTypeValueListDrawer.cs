#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomDrawer&lt;SOAttackTypeValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOAttackTypeValueList))]
    public class SOAttackTypeValueListDrawer : AtomDrawer<SOAttackTypeValueList> { }
}
#endif
