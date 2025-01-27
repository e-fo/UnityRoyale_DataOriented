#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomDrawer&lt;SOAttackTypeEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOAttackTypeEvent))]
    public class SOAttackTypeEventDrawer : AtomDrawer<SOAttackTypeEvent> { }
}
#endif
